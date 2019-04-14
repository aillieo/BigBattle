using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

namespace BigBattle.Client
{
    public class BattleUnitBehaviour : MonoBehaviour, IView, IClientPositionListener, IClientDirectionListener
    {
        public virtual void Link(IEntity entity)
        {
            gameObject.Link(entity);
            var e = (ClientEntity)entity;
            e.AddClientPositionListener(this);
            var pos = e.position.value;
            transform.localPosition = new Vector3(pos.x,0,pos.y);
        }

        public virtual void OnPosition(ClientEntity entity, Vec2 value)
        {
            transform.localPosition = new Vector3(value.x, 0, value.y);
        }

        public void OnDirection(ClientEntity entity, Vec2 value)
        {
            transform.localEulerAngles = CUtils.DirectionToRotation(value);
        }

        public virtual void OnDestroyed(ClientEntity entity)
        {
            DoDestroy();
        }

        protected virtual void DoDestroy()
        {
            gameObject.Unlink();
            Destroy(gameObject);
        }
    }

}