using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Client
{
    public class CReportReaderSystem : ReactiveSystem<ClientEntity>
    {
        readonly ClientContext _context;

        public CReportReaderSystem(Contexts contexts) : base(contexts.client)
        {
            _context = contexts.client;
        }

        protected override void Execute(List<ClientEntity> entities)
        {

            BattleFrameData battleFrameData = _context.GetFrameDate(_context.frameCounter.value);
            if (battleFrameData == null)
            {
                return;
            }

            foreach (var action in battleFrameData.battleActions)
            {
                _context.CreateEntity().AddBattleAction(action);
            }
        }

        protected override ICollector<ClientEntity> GetTrigger(IContext<ClientEntity> context)
        {
            return context.CreateCollector(ClientMatcher.FrameCounter);
        }

        protected override bool Filter(ClientEntity entity)
        {
            return entity.hasFrameCounter;
        }

    }
}
