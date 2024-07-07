using MementoMori.Common.Localization;
using MementoMori.Exceptions;
using MementoMori.Ortega.Share;
using MementoMori.Ortega.Share.Data.ApiInterface.Battle;
using MementoMori.Ortega.Share.Data.ApiInterface.TowerBattle;
using MementoMori.Ortega.Share.Enums;

namespace MementoMori;

public partial class MementoMoriFuncs
{
    public async Task BossTower()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            SelectedAutoTowerType = TowerType.Infinite;
            var targetStopLayer = 0;
            var selectedTargetQuerstId = 0;

            var towerTotalCount = 0;
            var towerWinCount = 0;
            var towerErrCount = 0;

            var bossTotalCount = 0;
            var bossWinCount = 0;
            var bossErrCount = 0;

            try
            {
                await GetResponse<NextQuestRequest, NextQuestResponse>(new NextQuestRequest());
            }
            catch (ApiErrorException e) when (e.ErrorCode == ErrorCode.BattleAutoNextQuestNotFound)
            {
            }

            Task bossTask = Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        var targetQuestId = UserSyncData.UserBattleBossDtoInfo.BossClearMaxQuestId + 1;
                        var bossResponse = await GetResponse<BossRequest, BossResponse>(new BossRequest() { QuestId = targetQuestId });
                        var win = bossResponse.BattleResult.SimulationResult.BattleEndInfo.IsWinAttacker();
                        bossTotalCount++;
                        if (win) bossWinCount++;
                        var info = Masters.QuestTable.GetById(targetQuestId).Memo;
                        var result = win ? Masters.TextResourceTable.Get("[LocalRaidBattleWinMessage]") : Masters.TextResourceTable.Get("[LocalRaidBattleLoseMessage]");
                        log($"B Total: {bossTotalCount} W: {bossWinCount} E: {bossErrCount} ({info})");
                        await _battleLogManager.SaveBattleLog(bossResponse.BattleResult, "main", bossResponse.BattleResult.QuestId.ToString(), autoDeletePrefix: "main-*lose");
                        if (win)
                        {
                            if (selectedTargetQuerstId > 0 && selectedTargetQuerstId == targetQuestId) return;
                            var nextQuestResponse = await GetResponse<NextQuestRequest, NextQuestResponse>(new NextQuestRequest());
                        }
                    }
                    catch (Exception e)
                    {
                        log(e.Message);
                        bossErrCount++;
                        if (bossErrCount > Max_Err_Count)
                        {
                            log(string.Format(ResourceStrings.AutoBossErrorMessage, Max_Err_Count));
                            return;
                        }
                        if (e is ApiErrorException) await AuthLogin(_lastPlayerDataInfo);
                    }
                }
            });

            // Tower
            Task towerTask = Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        var towerBattleDtoInfo = UserSyncData.UserTowerBattleDtoInfos.First(d => d.TowerType == SelectedAutoTowerType);
                        var tower = UserSyncData.UserTowerBattleDtoInfos.First(d => d.TowerType == SelectedAutoTowerType);
                        var targetQuestId = tower.MaxTowerBattleId + 1;
                        var bossQuickResponse = await GetResponse<StartRequest, StartResponse>(new StartRequest()
                        {
                            TargetTowerType = SelectedAutoTowerType,
                            TowerBattleQuestId = targetQuestId
                        });
                        var win = bossQuickResponse.BattleResult.SimulationResult.BattleEndInfo.IsWinAttacker();
                        towerTotalCount++;
                        if (win) towerWinCount++;
                        await _battleLogManager.SaveBattleLog(bossQuickResponse.BattleResult, $@"tower-{SelectedAutoTowerType}", bossQuickResponse.BattleResult.QuestId.ToString(), $"tower-{SelectedAutoTowerType}-*lose");
                        var name = Masters.TextResourceTable.Get(SelectedAutoTowerType);
                        var result = win ? Masters.TextResourceTable.Get("[LocalRaidBattleWinMessage]") : Masters.TextResourceTable.Get("[LocalRaidBattleLoseMessage]");
                        log($"T Total: {towerTotalCount} W: {towerWinCount} E: {towerErrCount} ({name} {targetQuestId})");
                        if (win && targetStopLayer > 0 && targetStopLayer == targetQuestId) return;
                    }
                    catch (Exception e)
                    {
                        log(e.Message);
                        towerErrCount++;
                        if (towerErrCount > Max_Err_Count)
                        {
                            log(string.Format(ResourceStrings.AutoBossErrorMessage, Max_Err_Count));
                            return;
                        }
                        if (e is ApiErrorException) await AuthLogin(_lastPlayerDataInfo);
                    }
                }
            });

            await Task.WhenAll(towerTask, bossTask);
        });
    }

}
