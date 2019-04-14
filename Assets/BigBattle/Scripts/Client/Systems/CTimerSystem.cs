using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace BigBattle.Client
{
    public class CTimerSystem : IExecuteSystem
    {
        readonly ClientContext _context;

        public CTimerSystem(Contexts contexts)
        {
            _context = contexts.client;
        }

        public void Execute()
        {
            float time = _context.GetTimeNow();
            time += Time.deltaTime;
            int frame = Mathf.FloorToInt(time / AppConst.TimeStep);

            _context.ReplaceTime(time);
            if(_context.frameCounter.value != frame)
            {
                _context.ReplaceFrameCounter(frame);
            }
        }
    }
}
