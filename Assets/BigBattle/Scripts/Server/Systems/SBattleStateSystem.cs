using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    public class SBattleStateSystem : IExecuteSystem
    {
        readonly ServerContext _context;

        public SBattleStateSystem(Contexts contexts)
        {
            _context = contexts.server;
        }

        public void Execute()
        {
            if (_context.frameCounter.value > AppConst.MaxFrameCount)
            {
                _context.isBattleEnd = true;
            }
            if (_context.GetTimeNow() > AppConst.MaxTimeCost)
            {
                _context.isBattleEnd = true;
            }
        }
    }

}
