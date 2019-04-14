using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BigBattle
{
    [Unique][Server]
    public class BattleConfigComponent : IComponent
    {
        public BattleConfig value;
    }
}
