using System.Threading;
using System.Threading.Tasks;

namespace MementoMori.Funcs;

public partial class MementoMoriFuncs
{
    public async Task AutoBossAndInfiniteTowerRequest(long targetBossQuestId = 0, long targetTowerStopLayer = 0)
    {
        if (SelectedAutoTowerType != TowerType.Infinite)
            SelectedAutoTowerType = TowerType.Infinite;

        var bossTask = AutoBossRequest(targetBossQuestId);
        var towerTask = AutoInfiniteTowerRequest(targetTowerStopLayer);

        await Task.WhenAll(bossTask, towerTask);
    }

    public async Task AutoBossAndAllTowersRequest(long targetBossQuestId = 0, long targetTowerStopLayer = 0)
    {
        // Don't modify SelectedAutoTowerType; AutoAllTowersRequest handles internally.
        var bossTask = AutoBossRequest(targetBossQuestId);
        var towersTask = AutoAllTowersRequest(targetTowerStopLayer);
        await Task.WhenAll(bossTask, towersTask);
    }
}
