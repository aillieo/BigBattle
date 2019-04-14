using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    public class SBattleActionCleanUpSystem : ICleanupSystem
    {
        readonly ServerContext _context;
        readonly IGroup<ServerEntity> _entities;

        public SBattleActionCleanUpSystem(Contexts contexts)
        {
            _context = contexts.server;
            _entities = _context.GetGroup(ServerMatcher.BattleAction);
        }

        public void Cleanup()
        {
            foreach (var e in _entities.GetEntities())
            {
                e.Destroy();
            }
        }
    }

}