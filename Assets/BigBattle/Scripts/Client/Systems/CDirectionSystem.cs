using System.Collections;
using System.Collections.Generic;
using Entitas;
using System;

namespace BigBattle.Client
{
    public class CDirectionSystem : ReactiveSystem<ClientEntity>
    {
        readonly ClientContext _context;

        public CDirectionSystem(Contexts contexts) : base(contexts.client)
        {
            _context = contexts.client;
        }

        protected override void Execute(List<ClientEntity> entities)
        {
            foreach (var e in entities)
            {
            }
        }

        protected override bool Filter(ClientEntity entity)
        {
            return entity.hasDirection;
            //return entity.hasDirection && entity.hasView;
        }

        protected override ICollector<ClientEntity> GetTrigger(IContext<ClientEntity> context)
        {
            return context.CreateCollector(ClientMatcher.Direction);
            //return context.CreateCollector(ClientMatcher.AllOf(ClientMatcher.Direction, ClientMatcher.View));
        }
    }
}
