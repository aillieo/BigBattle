using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    public class STargetingSystem : ReactiveSystem<ServerEntity>
    {
        readonly ServerContext _context;

        public STargetingSystem(Contexts contexts) : base(contexts.server)
        {
            _context = contexts.server;
        }

        protected override void Execute(List<ServerEntity> entities)
        {
            foreach (var e in entities)
            {
                Vec2 newTargetPos = _context.battleConfig.value.mapCenter;
                if (newTargetPos != e.targetPos.value)
                {
                    e.ReplaceTargetPos(newTargetPos);
                }
            }
        }

        protected override bool Filter(ServerEntity entity)
        {
            return entity.hasTargetPos;
        }

        protected override ICollector<ServerEntity> GetTrigger(IContext<ServerEntity> context)
        {
            return context.CreateCollector(ServerMatcher.TargetPos);
        }
    }

}
