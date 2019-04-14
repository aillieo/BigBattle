using System.Collections;
using System.Collections.Generic;

namespace BigBattle.Client
{
    public static class CContextExt
    {
        public static float GetTimeNow(this ClientContext context)
        {
            return context.time.value;
        }

        public static BattleFrameData GetFrameDate(this ClientContext context, int frame)
        {
            BattleReport battleReport = context.battleReport.value;
            BattleFrameData battleFrameData = null;
            battleReport.battleFrames.TryGetValue(frame, out battleFrameData);
            return battleFrameData;
        }
    }
}