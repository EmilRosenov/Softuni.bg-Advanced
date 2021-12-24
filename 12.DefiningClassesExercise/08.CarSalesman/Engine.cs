using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power, displacement)
        {
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"  {Model}:");
            result.AppendLine($"    Power: {Power}");

            if (Displacement == 0)
            {
                result.AppendLine($"    Displacement: n/a");
            }
            else
            {
                result.AppendLine($"    Displacement: {Displacement}");
            }

            if (Efficiency == null)
            {
                result.Append($"    Efficiency: n/a");
            }
            else
            {
                result.Append($"    Efficiency: {Efficiency}");
            }

            return result.ToString();
        }
    }
}
