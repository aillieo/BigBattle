using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle.Server
{
    [Server]
    public class TargetPosComponent : IComponent
    {
        public Vec2 value;
    }
}
