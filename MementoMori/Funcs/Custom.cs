using System.Collections.Concurrent;
using MementoMori.Exceptions;
using MementoMori.Ortega.Share.Data.ApiInterface.Battle;
using MementoMori.Ortega.Share.Data.ApiInterface.TowerBattle;

namespace MementoMori;

public partial class MementoMoriFuncs
{
    public async Task BossTower()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            SelectedAutoTowerType = TowerType.Infinite;
            var targetStopLayer = 0;
            var selectedTargetQuestId = 0;

            var stats = new ConcurrentDictionary<string, (int Total, int Win, int Err)>();
            stats["Boss"] = (0, 0, 0);
            stats["Tower"] = (0, 0, 0);

            try
            {
                await GetResponse<NextQuestRequest, NextQuestResponse>(new NextQuestRequest());
            }
            catch (ApiErrorException e) when (e.ErrorCode == ErrorCode.BattleAutoNextQuestNotFound)
            {
                // Ignore this specific error
            }

            async Task BossTask()
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        var targetQuestId = UserSyncData.UserBattleBossDtoInfo.BossClearMaxQuestId + 1;
                        var bossResponse = await GetResponse<BossRequest, BossResponse>(new BossRequest { QuestId = targetQuestId });
                        var win = bossResponse.BattleResult.SimulationResult.BattleEndInfo.IsWinAttacker();

                        stats.AddOrUpdate("Boss",
                            _ => (1, win ? 1 : 0, 0),
                            (_, old) => (old.Total + 1, old.Win + (win ? 1 : 0), old.Err));


                        var info = Masters.QuestTable.GetById(targetQuestId).Memo;
                        var result = win ? Masters.TextResourceTable.Get("[LocalRaidBattleWinMessage]") : Masters.TextResourceTable.Get("[LocalRaidBattleLoseMessage]");
                        var currentStats = stats["Boss"];
                        log($"B Total: {currentStats.Total} W: {currentStats.Win} E: {currentStats.Err} ({info})");

                        await _battleLogManager.SaveBattleLog(bossResponse.BattleResult, "main", bossResponse.BattleResult.QuestId.ToString(), autoDeletePrefix: "main-*lose");

                        if (win)
                        {
                            if (selectedTargetQuestId > 0 && selectedTargetQuestId == targetQuestId) return;
                            await GetResponse<NextQuestRequest, NextQuestResponse>(new NextQuestRequest());
                        }
                    }
                    catch (Exception e)
                    {
                        log(e.Message);
                        stats.AddOrUpdate("Boss",
                            _ => (0, 0, 1),
                            (_, old) => (old.Total, old.Win, old.Err + 1));
                        if (e is ApiErrorException) await AuthLogin(_lastPlayerDataInfo);
                    }
                }
            }

            async Task TowerTask()
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        var tower = UserSyncData.UserTowerBattleDtoInfos.First(d => d.TowerType == SelectedAutoTowerType);
                        var targetQuestId = tower.MaxTowerBattleId + 1;
                        var bossQuickResponse = await GetResponse<StartRequest, StartResponse>(new StartRequest
                        {
                            TargetTowerType = SelectedAutoTowerType,
                            TowerBattleQuestId = targetQuestId
                        });

                        var win = bossQuickResponse.BattleResult.SimulationResult.BattleEndInfo.IsWinAttacker();
                        stats.AddOrUpdate("Tower",
                            _ => (1, win ? 1 : 0, 0),
                            (_, old) => (old.Total + 1, old.Win + (win ? 1 : 0), old.Err));

                        await _battleLogManager.SaveBattleLog(bossQuickResponse.BattleResult, $"tower-{SelectedAutoTowerType}", bossQuickResponse.BattleResult.QuestId.ToString(), $"tower-{SelectedAutoTowerType}-*lose");

                        var name = Masters.TextResourceTable.Get(SelectedAutoTowerType);
                        var result = win ? Masters.TextResourceTable.Get("[LocalRaidBattleWinMessage]") : Masters.TextResourceTable.Get("[LocalRaidBattleLoseMessage]");
                        var currentStats = stats["Tower"];
                        log($"T Total: {currentStats.Total} W: {currentStats.Win} E: {currentStats.Err} ({name} {targetQuestId})");

                        if (win && targetStopLayer > 0 && targetStopLayer == targetQuestId) return;
                    }
                    catch (Exception e)
                    {
                        log(e.Message);
                        stats.AddOrUpdate("Tower",
                            _ => (0, 0, 1),
                            (_, old) => (old.Total, old.Win, old.Err + 1));
                        if (e is ApiErrorException) await AuthLogin(_lastPlayerDataInfo);
                    }
                }
            }

            var tasks = new List<Task>
            {
                Task.Run(BossTask),
                Task.Run(TowerTask),
            };

            await Task.WhenAll(tasks);
        });
    }
}
