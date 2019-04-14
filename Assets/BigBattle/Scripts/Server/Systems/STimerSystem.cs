using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    public class STimerSystem : IExecuteSystem
    {
        readonly ServerContext _context;
        public float timeStep = AppConst.TimeStep;

        public STimerSystem(Contexts contexts)
        {
            _context = contexts.server;
        }

        public void Execute()
        {
            var newFrame = _context.frameCounter.value + 1;
            _context.ReplaceFrameCounter(newFrame);
        }
    }

}
