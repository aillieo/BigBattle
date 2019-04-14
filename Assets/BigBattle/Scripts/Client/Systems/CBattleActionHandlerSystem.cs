using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Client
{
    public class CBattleActionHandlerSystem : ReactiveSystem<ClientEntity>
    {
        readonly ClientContext _context;

        public CBattleActionHandlerSystem(Contexts contexts) : base(contexts.client)
        {
            _context = contexts.client;
        }

        protected override void Execute(List<ClientEntity> entities)
        {
            foreach (var e in entities)
            {
                BattleAction action = e.battleAction.value;
                BattleActionType type = action.type;
                int id = action.subject;
                ClientEntity subject = _context.GetEntityWithBattleUnitId(id);

                switch (type)
                {
                    case BattleActionType.Move:
                        BattleActionMove battleActionMove = action as BattleActionMove;
                        subject.ReplaceSpeed(battleActionMove.speed);
                        subject.ReplaceDirection(battleActionMove.dir);
                        break;
                    case BattleActionType.Stop:
                        BattleActionStop battleActionStop = action as BattleActionStop;
                        subject.ReplaceSpeed(0);
                        subject.ReplacePosition(battleActionStop.position);
                        break;
                    default:
                        break;
                }
            }
        }

        protected override ICollector<ClientEntity> GetTrigger(IContext<ClientEntity> context)
        {
            return context.CreateCollector(ClientMatcher.BattleAction);
        }

        protected override bool Filter(ClientEntity entity)
        {
            return entity.hasBattleAction;
        }

    }
}
