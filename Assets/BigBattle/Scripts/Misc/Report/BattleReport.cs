using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BigBattle
{
    [Serializable]
    public class BattleReport
    {
        public BattleReport(BattleConfig battleConfig)
        {
            battleMeta = new BattleMeta(battleConfig);
        }

        public BattleMeta battleMeta;
        public SortedList<int,BattleFrameData> battleFrames = new SortedList<int, BattleFrameData>();
    }

}
