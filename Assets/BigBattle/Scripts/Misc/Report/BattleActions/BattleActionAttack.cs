using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleActionAttack : BattleAction
    {
        public BattleActionAttack()
        {
            this.type = BattleActionType.Attack;
        }

    }
}
