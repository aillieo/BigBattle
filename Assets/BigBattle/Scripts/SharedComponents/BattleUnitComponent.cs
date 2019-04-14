using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BigBattle
{
    [Server][Client]
    public class BattleUnitComponent : IComponent
    {
        public BattleUnitData value;
    }
}
