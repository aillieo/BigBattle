using System.Collections;
using System.Collections.Generic;
using System;

namespace BigBattle
{

    [Serializable]
    public struct Vec2
    {
        public float x { get => m_x; set => m_x = value; }
        public float y { get => m_y; set => m_y = value; }

        private const float kEpsilon = 0.00001F;

        [UnityEngine.SerializeField]
        private float m_x;
        [UnityEngine.SerializeField]
        private float m_y;

        public Vec2(float x, float y)
        {
            m_x = x;
            m_y = y;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vec2)) return false;

            return Equals((Vec2)obj);
        }

        public bool Equals(Vec2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public void Normalize()
        {
            float mag = magnitude;
            if (mag > kEpsilon)
                this = this / mag;
            else
                this = zero;
        }

        [Newtonsoft.Json.JsonIgnore]
        public Vec2 normalized
        {
            get
            {
                Vec2 v = new Vec2(x, y);
                v.Normalize();
                return v;
            }
        }

        public static Vec2 Max(Vec2 lhs, Vec2 rhs) { return new Vec2(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y)); }

        public static Vec2 zero = new Vec2(0, 0);

        [Newtonsoft.Json.JsonIgnore]
        public float magnitude
        {
            get { return (float)Math.Sqrt(sqrMagnitude); }
        }

        [Newtonsoft.Json.JsonIgnore]
        public float sqrMagnitude
        {
            get { return x * x + y * y; }
        }

        public static float Distance(Vec2 a, Vec2 b) { return (a - b).magnitude; }

        public override string ToString()
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }

        public static float operator *(Vec2 vector1, Vec2 vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y;
        }

        public static Vec2 operator *(float scalar, Vec2 vector)
        {
            return vector * scalar;
        }

        public static Vec2 operator *(Vec2 vector, float scalar)
        {
            return new Vec2(vector.x * scalar, vector.y * scalar);
        }

        public static Vec2 operator /(Vec2 vector, float scalar)
        {
            return new Vec2(vector.x / scalar, vector.y / scalar);
        }

        public static Vec2 operator +(Vec2 vector1, Vec2 vector2)
        {
            return new Vec2(vector1.x + vector2.x, vector1.y + vector2.y);
        }

        public static Vec2 operator -(Vec2 vector1, Vec2 vector2)
        {
            return new Vec2(vector1.x - vector2.x, vector1.y - vector2.y);
        }

        public static Vec2 operator -(Vec2 vector)
        {
            return new Vec2(-vector.x, -vector.y);
        }

        public static bool operator ==(Vec2 lhs, Vec2 rhs)
        {
            return (lhs - rhs).sqrMagnitude < kEpsilon * kEpsilon;
        }

        public static bool operator !=(Vec2 lhs, Vec2 rhs)
        {
            return !(lhs == rhs);
        }

        public static implicit operator UnityEngine.Vector2(Vec2 vector)
        {
            return new UnityEngine.Vector2(vector.x, vector.y);
        }

        public static implicit operator RVO.Vector2(Vec2 vector)
        {
            return new RVO.Vector2(vector.x, vector.y);
        }

    }
}