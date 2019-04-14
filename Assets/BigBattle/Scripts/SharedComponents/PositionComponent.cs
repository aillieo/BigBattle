using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BigBattle
{
    [Server][Client][Event(EventTarget.Self)]
    public class PositionComponent : IComponent
    {
        public Vec2 value;
    }
}
