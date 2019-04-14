using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Client
{
    public class CBattleInitSystem : IInitializeSystem
    {
        readonly ClientContext _context;

        public CBattleInitSystem(Contexts contexts)
        {
            _context = contexts.client;
        }

        public void Initialize()
        {
            var battleReport = _context.battleReport.value;
            var battleConfig = battleReport.battleMeta.battleConfig;

            // unique
            var unique = _context.CreateEntity();
            unique.AddTime(0f);
            unique.AddFrameCounter(0);
            unique.isBattleEnd = false;
            unique.AddRandom(new BigBattle.Random(battleConfig.randomSeed));

            // actors
            int unitIndex = 1;
            int teamIndex = 1;
            var teams = battleConfig.battleTeams;
            foreach (var team in teams)
            {
                foreach (var unit in team.battleUnits)
                {
                    var e = _context.CreateEntity();
                    e.AddBattleUnitId(unitIndex);
                    e.AddBattleTeam(teamIndex);
                    e.AddBattleUnit(unit);
                    e.AddAsset(new AssetNamePair("Prefabs/BattleUnits", unit.assetName));
                    e.AddPosition(team.birthPlace);
                    unitIndex++;
                }
                teamIndex++;
            }
        }
    }

}
