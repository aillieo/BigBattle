using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    public class SBattleActionSystem : ReactiveSystem<ServerEntity>
    {
        readonly ServerContext _context;

        public SBattleActionSystem(Contexts contexts) : base(contexts.server)
        {
            _context = contexts.server;
        }

        protected override void Execute(List<ServerEntity> entities)
        {
            int frame = _context.frameCounter.value;
            foreach (var e in entities)
            {
                _context.ReportBattleAction(e.battleAction.value);
            }
        }
        
        protected override bool Filter(ServerEntity entity)
        {
            return entity.hasBattleAction;
        }

        protected override ICollector<ServerEntity> GetTrigger(IContext<ServerEntity> context)
        {
            return context.CreateCollector(ServerMatcher.BattleAction);
        }

    }

}
