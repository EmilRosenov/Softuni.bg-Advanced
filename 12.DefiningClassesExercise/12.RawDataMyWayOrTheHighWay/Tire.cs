using System;
using System.Collections.Generic;
using System.Text;

namespace _12.RawDataMyWayOrTheHighWay
{
    public class Tire
    {
        Tire[] tires = new Tire[4];
        public Tire(double tirePressure, int tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;
        }

        public double TirePressure { get; set; }
        public int TireAge { get; set; }
    }
}
