using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace BigBattle.Client
{
    public class CBattleUnitCreateSystem : ReactiveSystem<ClientEntity>
    {
        readonly Transform battleUnitRoot;

        public CBattleUnitCreateSystem(Contexts contexts) : base(contexts.client)
        {
            string rootName = "BattleUnitRoot";
            GameObject root = GameObject.Find(rootName);
            if(root)
            {
                battleUnitRoot = root.transform;
            }
            else
            {
                battleUnitRoot = new GameObject(rootName).transform;
            }
        }

        protected override ICollector<ClientEntity> GetTrigger(IContext<ClientEntity> context)
        {
            return context.CreateCollector(ClientMatcher.Asset);
        }

        protected override bool Filter(ClientEntity entity)
        {
            return entity.hasAsset;
        }

        protected override void Execute(List<ClientEntity> entities)
        {
            foreach (var e in entities)
            {
                BattleUnitBehaviour view = CreateBattleUnitView(e);
                e.AddView(view);
                e.AddClientPositionListener(view);
                e.AddClientDirectionListener(view);
            }
        }

        private BattleUnitBehaviour CreateBattleUnitView(ClientEntity entity)
        {
            var go = Service.Instance.gameObjectCreateService.CreateGameObject(entity.asset.value);
            go.transform.SetParent(battleUnitRoot, false);
            BattleUnitBehaviour view = go.GetComponent<BattleUnitBehaviour>();
            view.Link(entity);
            return view;
        }
    }
}