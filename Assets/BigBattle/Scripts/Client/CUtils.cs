using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigBattle.Client
{
    public static class CUtils
    {
        public static Vector3 DirectionToRotation(Vec2 dir)
        {
            var angle = Vector2.SignedAngle(Vector2.right, dir);
            return Vector3.up * angle;
        }
    }
}