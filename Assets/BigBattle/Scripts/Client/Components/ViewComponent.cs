using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace BigBattle.Client
{
    [Client]
    public sealed class ViewComponent : IComponent
    {
        public IView value;
    }

}