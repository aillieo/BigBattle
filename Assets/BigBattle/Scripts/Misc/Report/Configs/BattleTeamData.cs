using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleTeamData 
    {
        public BattleUnitData[] battleUnits;
        [SerializeField]
        public Vec2 birthPlace;
    }
}
