using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleActionStop : BattleAction
    {
        [SerializeField]
        public Vec2 position;

        public BattleActionStop()
        {
            this.type = BattleActionType.Stop;
        }

    }
}
