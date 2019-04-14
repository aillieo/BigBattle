using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BigBattle
{
    [Unique][Server][Client]
    public class RandomComponent : IComponent
    {
        public BigBattle.Random value;
    }
}
