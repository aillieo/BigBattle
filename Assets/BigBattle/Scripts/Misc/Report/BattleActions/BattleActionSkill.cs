using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleActionSkill : BattleAction
    {
        [SerializeField]
        public Vec2 dir;

        public BattleActionSkill()
        {
            this.type = BattleActionType.Skill;
        }
    }
}
