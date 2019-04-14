using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace BigBattle.Client
{
    public interface IView
    {
        void Link(IEntity entity);
    }

}