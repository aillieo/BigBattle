using System.Collections;
using System.Collections.Generic;
using Entitas;

namespace BigBattle
{
    [Server][Client]
    public class SpeedComponent : IComponent
    {
        public float value;
    }
}
