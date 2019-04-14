using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleFrameData
    {
        public float time;
        [SerializeField]
        public List<BattleAction> battleActions = new List<BattleAction>();
    }
}

