using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BigBattle
{
    [Server][Client]
    [Event(EventTarget.Self)]
    public class DirectionComponent : IComponent
    {
        public Vec2 value;
    }
}
