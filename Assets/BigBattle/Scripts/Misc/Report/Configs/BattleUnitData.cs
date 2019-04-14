using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleUnitData 
    {
        // view
        public string name;
        public string assetName;

        // unit
        public float size;
        public float moveSpeed;

        // about attacking
        // public int attackType;
        public float attackDamage;
        public float attackInterval;
        public float attackRange;

        // about attacked
        // public int armorType;
        public float armor;
        public float hitPoints;
        public float regenerate;
    }

}
