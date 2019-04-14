using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    public class SBattleInitSystem : IInitializeSystem
    {
        readonly ServerContext _context;

        public SBattleInitSystem(Contexts contexts)
        {
            _context = contexts.server;
        }

        public void Initialize()
        {
            BattleConfig battleConfig = _context.battleConfig.value;

            // unique
            var unique = _context.CreateEntity();
            unique.AddFrameCounter(0);
            unique.AddRandom(new BigBattle.Random(battleConfig.randomSeed));
            unique.isBattleEnd = false;
            unique.AddBattleReport(new BattleReport(battleConfig));

            // actors
            int unitIndex = 1;
            int teamIndex = 1;
            foreach(var team in battleConfig.battleTeams)
            {
                foreach (var unit in team.battleUnits)
                {
                    var e = _context.CreateEntity();
                    e.AddBattleUnitId(unitIndex);
                    e.AddBattleTeam(teamIndex);
                    e.AddBattleUnit(unit);
                    e.AddPosition(team.birthPlace);
                    e.AddTargetPos(battleConfig.mapCenter);
                    e.AddDirection(Vec2.zero);
                    e.AddSpeed(unit.moveSpeed);
                    e.isMoving = true;

                    unitIndex++;
                }
                teamIndex++;
            }
        }
    }

}
