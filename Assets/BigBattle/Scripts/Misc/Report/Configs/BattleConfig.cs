using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace BigBattle
{
    [Serializable]
    public class BattleConfig
    {
        [SerializeField]
        public int randomSeed;
        [SerializeField]
        public Vec2 mapSize;
        [SerializeField]
        public BattleTeamData[] battleTeams;

        // 临时使用的
        public Vec2 mapCenter { get { return mapSize / 2; } }
    }

}
