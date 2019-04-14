using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BigBattle.Client
{
    [Client][Unique]
    public sealed class TimeComponent : IComponent
    {
        public float value;
    }

}