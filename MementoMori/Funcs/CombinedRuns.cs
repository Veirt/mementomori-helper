namespace MementoMori.Funcs;

public partial class MementoMoriFuncs
{
    public async Task AutoBossAndInfiniteTowerRequest(long targetBossQuestId = 0, long targetTowerStopLayer = 0)
    {
        await AutoBossAndTowerRequest(TowerType.Infinite, targetBossQuestId, targetTowerStopLayer);
    }

    public async Task AutoBossAndSelectedTowerRequest(long targetBossQuestId = 0, long targetTowerStopLayer = 0)
    {
        var towerType = SelectedAutoTowerType == TowerType.None ? TowerType.Infinite : SelectedAutoTowerType;
        await AutoBossAndTowerRequest(towerType, targetBossQuestId, targetTowerStopLayer);
    }

    public async Task AutoBossAndTowerRequest(TowerType towerType, long targetBossQuestId = 0, long targetTowerStopLayer = 0)
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            if (!LoginOk) return;

            log($"[AutoBattle] Start: main,{towerType}");
            await WhenAllLogExceptions(new[]
            {
                RunBossLoop(targetBossQuestId, log, token),
                RunTowerTypeLoop(towerType, targetTowerStopLayer, log, token)
            }, log);
        });
    }

    public async Task AutoBossAndAllTowersRequest(long targetBossQuestId = 0, long targetTowerStopLayer = 0)
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            if (!LoginOk) return;

            var towerTypes = GetAvailableTower().Distinct().ToArray();
            if (towerTypes.Length == 0)
            {
                await RunBossLoop(targetBossQuestId, log, token);
                return;
            }

            log($"[AutoBattle] Start: main,{string.Join(",", towerTypes.Select(t => t.ToString()))}");

            var tasks = towerTypes
                .Select(t => RunTowerTypeLoop(t, targetTowerStopLayer, log, token))
                .Prepend(RunBossLoop(targetBossQuestId, log, token))
                .ToArray();
            await WhenAllLogExceptions(tasks, log);
        });
    }
}
