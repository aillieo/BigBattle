using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    public class SMoveSystem : IExecuteSystem
    {
        readonly ServerContext _context;

        public SMoveSystem(Contexts contexts)
        {
            _context = contexts.server;
        }

        public void Execute()
        {
            var entities = _context.GetGroup(ServerMatcher.Position);
            foreach (var e in entities)
            {
                if (!e.isMoving)
                {
                    continue;
                }

                var oldPos = e.position.value;
                var newPos = oldPos + e.direction.value * e.speed.value * AppConst.TimeStep;
                e.ReplacePosition(newPos);


                // 足够近
                float distance = Vec2.Distance(e.targetPos.value, e.position.value);
                if (distance < e.speed.value * AppConst.TimeStep)
                {
                    if (Math.Abs(distance) < AppConst.Epsilon)
                    {
                        e.isMoving = false;
                        BattleAction battleAction = new BattleActionStop()
                        {
                            subject = e.battleUnitId.value,
                            position = e.position.value
                        };
                        _context.CreateEntity().AddBattleAction(battleAction);
                    }
                    else
                    {
                        var dir = e.direction.value;
                        e.ReplaceSpeed(distance / AppConst.TimeStep);
                        BattleAction battleAction = new BattleActionMove()
                        {
                            subject = e.battleUnitId.value,
                            speed = e.speed.value,
                            dir = e.direction.value
                        };
                        _context.CreateEntity().AddBattleAction(battleAction);
                    }
                }
            }
        }
    }

}
