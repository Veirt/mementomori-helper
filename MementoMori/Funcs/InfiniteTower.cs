using MementoMori.Exceptions;
using MementoMori.Ortega.Share.Data.ApiInterface.TowerBattle;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MementoMori.Funcs;

public partial class MementoMoriFuncs
{
    public async Task AutoInfiniteTowerRequest(long targetStopLayer)
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            if (SelectedAutoTowerType == TowerType.None) return;

            var totalCount = 0;
            var winCount = 0;
            var errCount = 0;
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var towerBattleDtoInfo = UserSyncData.UserTowerBattleDtoInfos.First(d => d.TowerType == SelectedAutoTowerType);
                    if (SelectedAutoTowerType != TowerType.Infinite && towerBattleDtoInfo.TodayClearNewFloorCount >= 10)
                    {
                        log($"{SelectedAutoTowerType} {TextResourceTable.Get("[ClientErrorMessage1700007]")}");
                        break;
                    }

                    var tower = UserSyncData.UserTowerBattleDtoInfos.First(d => d.TowerType == SelectedAutoTowerType);
                    var targetQuestId = tower.MaxTowerBattleId + 1;
                    var bossQuickResponse = await GetResponse<StartRequest, StartResponse>(new StartRequest
                    {
                        TargetTowerType = SelectedAutoTowerType, TowerBattleQuestId = targetQuestId
                    });
                    var win = bossQuickResponse.BattleResult.SimulationResult.BattleEndInfo.IsWinAttacker();
                    totalCount++;
                    if (win) winCount++;

                    await _battleLogManager.SaveBattleLog(bossQuickResponse.BattleResult, $@"tower-{SelectedAutoTowerType}", bossQuickResponse.BattleResult.QuestId.ToString(),
                        $"tower-{SelectedAutoTowerType}-*lose");

                    var name = TextResourceTable.Get(SelectedAutoTowerType);
                    var result = win ? TextResourceTable.Get("[LocalRaidBattleWinMessage]") : TextResourceTable.Get("[LocalRaidBattleLoseMessage]");

                    if (SelectedAutoTowerType == TowerType.Infinite)
                        log(string.Format(ResourceStrings.AutoTowerInfiniteExecMsg, name, targetQuestId, result, totalCount, winCount, errCount));
                    else
                        log(string.Format(ResourceStrings.AutoTowerElementExecMsg, name, targetQuestId, result, totalCount, winCount, errCount, towerBattleDtoInfo.TodayClearNewFloorCount));

                    if (win && targetStopLayer > 0 && targetStopLayer == targetQuestId) break;
                }
                catch (Exception e)
                {
                    log(e.Message);
                    errCount++;
                    if (errCount > Max_Err_Count)
                    {
                        log(string.Format(ResourceStrings.AutoBossErrorMessage, Max_Err_Count));
                        return;
                    }

                    if (e is ApiErrorException) await AuthLogin(_lastPlayerDataInfo);
                }
            }
        });
    }

    public async Task AutoAllTowersRequest(long targetStopLayer)
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            if (!LoginOk) return;

            // Get available towers for the day (includes Infinite)
            var towerTypes = GetAvailableTower().Distinct().ToArray();
            if (towerTypes.Length == 0) return;

            log($"[AutoTower] Start: {string.Join(",", towerTypes.Select(t => t.ToString()))}");

            var tasks = towerTypes.Select(t => RunTowerTypeLoop(t, targetStopLayer, log, token)).ToArray();
            await Task.WhenAll(tasks);
        });
    }

    private async Task RunTowerTypeLoop(TowerType towerType, long targetStopLayer, Action<string> log, CancellationToken token)
    {
        var totalCount = 0;
        var winCount = 0;
        var errCount = 0;

        while (!token.IsCancellationRequested)
        {
            try
            {
                var towerInfo = UserSyncData.UserTowerBattleDtoInfos.FirstOrDefault(d => d.TowerType == towerType);
                if (towerInfo == null)
                {
                    log($"[Tower:{towerType}] data not found");
                    break;
                }

                if (towerType != TowerType.Infinite && towerInfo.TodayClearNewFloorCount >= 10)
                {
                    // Daily limit reached for elemental tower
                    log($"[Tower:{towerType}] {TextResourceTable.Get("[ClientErrorMessage1700007]")}");
                    break;
                }

                var targetQuestId = towerInfo.MaxTowerBattleId + 1;
                var response = await GetResponse<StartRequest, StartResponse>(new StartRequest
                {
                    TargetTowerType = towerType,
                    TowerBattleQuestId = targetQuestId
                });

                var win = response.BattleResult.SimulationResult.BattleEndInfo.IsWinAttacker();
                totalCount++;
                if (win) winCount++;

                await _battleLogManager.SaveBattleLog(response.BattleResult, $"tower-{towerType}", response.BattleResult.QuestId.ToString(), $"tower-{towerType}-*lose");

                var name = TextResourceTable.Get(towerType);
                var result = win ? TextResourceTable.Get("[LocalRaidBattleWinMessage]") : TextResourceTable.Get("[LocalRaidBattleLoseMessage]");

                if (towerType == TowerType.Infinite)
                    log($"[Tower:{towerType}] " + string.Format(ResourceStrings.AutoTowerInfiniteExecMsg, name, targetQuestId, result, totalCount, winCount, errCount));
                else
                    log($"[Tower:{towerType}] " + string.Format(ResourceStrings.AutoTowerElementExecMsg, name, targetQuestId, result, totalCount, winCount, errCount, towerInfo.TodayClearNewFloorCount));

                if (win && targetStopLayer > 0 && targetStopLayer == targetQuestId) break;
            }
            catch (Exception e)
            {
                log($"[Tower:{towerType}] {e.Message}");
                errCount++;
                if (errCount > Max_Err_Count)
                {
                    log($"[Tower:{towerType}] " + string.Format(ResourceStrings.AutoBossErrorMessage, Max_Err_Count));
                    return;
                }

                if (e is ApiErrorException)
                {
                    await AuthLogin(_lastPlayerDataInfo);
                }
            }
        }
    }

    public TowerType[] GetAvailableTower()
    {
        if (!LoginOk) return Array.Empty<TowerType>();

        foreach (var limitedEventMb in LimitedEventTable.GetArray().Where(d => d.LimitedEventType == LimitedEventType.ElementTowerAllRelease))
        {
            if (NetworkManager.TimeManager.IsInTime(limitedEventMb)) return new[] {TowerType.Infinite, TowerType.Blue, TowerType.Green, TowerType.Red, TowerType.Yellow};
        }

        var now = DateTimeOffset.UtcNow.ToOffset(TimeManager.DiffFromUtc) - TimeSpan.FromHours(4);
        var dayOfWeek = now.DayOfWeek;
        // SelectedAutoTowerType = TowerType.Infinite;
        return dayOfWeek switch
        {
            DayOfWeek.Sunday => new[] {TowerType.Infinite, TowerType.Blue, TowerType.Green, TowerType.Red, TowerType.Yellow},
            DayOfWeek.Monday => new[] {TowerType.Infinite, TowerType.Blue},
            DayOfWeek.Tuesday => new[] {TowerType.Infinite, TowerType.Red},
            DayOfWeek.Wednesday => new[] {TowerType.Infinite, TowerType.Green},
            DayOfWeek.Thursday => new[] {TowerType.Infinite, TowerType.Yellow},
            DayOfWeek.Friday => new[] {TowerType.Infinite, TowerType.Blue, TowerType.Red},
            DayOfWeek.Saturday => new[] {TowerType.Infinite, TowerType.Yellow, TowerType.Green},
            _ => new[] {TowerType.Infinite}
        };
    }

    public async Task InfiniteTowerQuick()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            try
            {
                var tower = UserSyncData.UserTowerBattleDtoInfos.First(d => d.TowerType == TowerType.Infinite);
                log($"{TextResourceTable.Get("[CommonHeaderTowerBattleLabel]")}:\n");

                if (IsBossBattleQuickAvailable)
                {
                    var bossQuickResponse = await GetResponse<TowerBattleQuickRequest, TowerBattleQuickResponse>(
                        new TowerBattleQuickRequest
                        {
                            TargetTowerType = TowerType.Infinite, TowerBattleQuestId = tower.MaxTowerBattleId, QuickCount = 3
                        });
                    if (bossQuickResponse.BattleRewardResult != null)
                    {
                        bossQuickResponse.BattleRewardResult.FixedItemList.PrintUserItems(log);
                        bossQuickResponse.BattleRewardResult.DropItemList.PrintUserItems(log);
                    }
                }
                else
                {
                    for (var i = 0; i < 3; i++)
                    {
                        var bossQuickResponse = await GetResponse<StartRequest, StartResponse>(
                            new StartRequest
                            {
                                TargetTowerType = TowerType.Infinite, TowerBattleQuestId = tower.MaxTowerBattleId
                            });
                        if (bossQuickResponse.BattleRewardResult != null)
                        {
                            bossQuickResponse.BattleRewardResult.FixedItemList.PrintUserItems(log);
                            bossQuickResponse.BattleRewardResult.DropItemList.PrintUserItems(log);
                        }
                    }
                }
            }
            catch (ApiErrorException e) when (e.ErrorCode == ErrorCode.TowerBattleNotEnoughChallengeCount)
            {
                log(e.Message);
            }
        });
    }
}