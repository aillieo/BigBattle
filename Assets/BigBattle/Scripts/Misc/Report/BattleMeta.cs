using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleMeta
    {
        public BattleMeta(BattleConfig battleConfig)
        {
            this.battleConfig = battleConfig;
            this.timeStep = AppConst.TimeStep;
        }

        public BattleConfig battleConfig;
        public float timeStep;
        public float timeCost;
        public int frameCount;
        public int frameDataCount;
        public int actionCount;
    }

}
