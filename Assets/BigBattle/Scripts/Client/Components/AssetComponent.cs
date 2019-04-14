using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace BigBattle
{
    [Client]
    public class AssetComponent : IComponent
    {
        public AssetNamePair value;
    }
}
