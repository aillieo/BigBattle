using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BigBattle
{
    [Server][Client]
    public class BattleTeamComponent : IComponent
    {
        [EntityIndex]
        public int value;
    }
}
