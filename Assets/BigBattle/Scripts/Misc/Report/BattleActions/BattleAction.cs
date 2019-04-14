using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    public enum BattleActionType 
    {
        Empty = 0,
        Move = 1,
        Stop = 2,
        Attack = 3,
        Skill = 4,
}

    [Serializable]
    public abstract class BattleAction
    {
        public BattleActionType type;
        public int subject;
    }
}
