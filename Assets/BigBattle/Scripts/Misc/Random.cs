using System;
using System.Collections.Generic;
using SRandom = System.Random;

namespace BigBattle
{
    public class Random
    {
        private readonly SRandom rand;

        public Random(int seed)
        {
            rand = new SRandom(seed);
        }

        public int Int()
        {
            return this.rand.Next();
        }

        public int Int(int max)
        {
            return this.rand.Next(max);
        }

        public int Int(int min, int max) 
        {   
            return this.rand.Next(min, max);
        }

        public float Float()
        {
            return (float)this.rand.NextDouble();
        }

        public float Float(float min, float max)
        {
            return min + (max - min) * Float();
        }
        
    }

}