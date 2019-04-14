using System.Collections;
using System.Collections.Generic;
using Entitas;
using System;

namespace BigBattle.Server
{
    public class SSpeedSystem : ReactiveSystem<ServerEntity>
    {
        readonly ServerContext _context;

        public SSpeedSystem(Contexts contexts) : base(contexts.server)
        {
            _context = contexts.server;
        }

        protected override void Execute(List<ServerEntity> entities)
        {
        
            foreach (var e in entities)
            {
                var dir = e.targetPos.value - e.position.value;
                dir.Normalize();
                if(dir != e.direction.value)
                {
                    e.ReplaceDirection(dir);

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

        protected override bool Filter(ServerEntity entity)
        {
            return entity.hasSpeed;
        }

        protected override ICollector<ServerEntity> GetTrigger(IContext<ServerEntity> context)
        {
            return context.CreateCollector(ServerMatcher.AnyOf(ServerMatcher.TargetPos, ServerMatcher.Speed));
        }
    }
}
