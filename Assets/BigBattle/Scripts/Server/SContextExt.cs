using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AillieoUtils;
using Entitas;
using System;

namespace BigBattle.Server
{
    public static class SContextExt
    {
        public static float GetTimeNow(this ServerContext context)
        {
            return AppConst.TimeStep * context.frameCounter.value;
        }

        public static void ReportBattleAction(this ServerContext context, BattleAction battleAction)
        {
            BattleReport battleReport = context.battleReport.value;
            int frame = context.frameCounter.value;
            float time = context.GetTimeNow();

            BattleFrameData battleFrameData = null;
            if (!battleReport.battleFrames.TryGetValue(frame, out battleFrameData))
            {
                battleFrameData = new BattleFrameData();
                battleFrameData.time = time;
                battleReport.battleFrames.Add(frame, battleFrameData);
                battleReport.battleMeta.frameDataCount++;
                battleReport.battleMeta.timeCost = time;
                battleReport.battleMeta.frameCount = frame;
            }
            battleFrameData.battleActions.Add(battleAction);
            battleReport.battleMeta.actionCount++;
        }
    }
}