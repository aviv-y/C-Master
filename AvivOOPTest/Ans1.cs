using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivOOPTest
{
    abstract class Car
    {
        abstract public float Speed(float time, float distance);
    }

    internal class Track:Car
    {
        public override float Speed(float t, float d)
        {
            return d / t;
        }
    }
    internal class Ans1
    {
        Track track = new Track();
        public void Run()
        {
            track.Speed(45, 3500);
        }
    }
}
