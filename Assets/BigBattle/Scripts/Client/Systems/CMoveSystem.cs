using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Client
{
    public class CMoveSystem : IExecuteSystem
    {
        readonly ClientContext _context;

        public CMoveSystem(Contexts contexts)
        {
            _context = contexts.client;
        }

        public void Execute()
        {
            var entities = _context.GetEntities<ClientEntity>(ClientMatcher.AllOf(ClientMatcher.Position, ClientMatcher.Speed, ClientMatcher.Direction));
            foreach (var e in entities)
            {
                var oldPos = e.position.value;
                var speed = e.speed.value;
                var dir = e.direction.value;
                var newPos = oldPos + dir * speed * UnityEngine.Time.deltaTime;
                e.ReplacePosition(newPos);
            }
        }

    }

}
