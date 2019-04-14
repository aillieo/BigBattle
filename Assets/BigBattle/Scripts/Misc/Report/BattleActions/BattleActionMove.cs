using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleActionMove : BattleAction
    {
        [SerializeField]
        public Vec2 dir;
        public float speed;

        public BattleActionMove()
        {
            this.type = BattleActionType.Move;
        }
    }
}
