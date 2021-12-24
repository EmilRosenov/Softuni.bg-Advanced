using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
           Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
           Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, weight)
        {
            Color = color;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"{Model}:");
            result.AppendLine($"{Engine}");

            if (Weight == 0)
            {
                result.AppendLine($"  Weight: n/a");
            }
            else
            {
                result.AppendLine($"  Weight: {Weight}");
            }

            if (Color == null)
            {
                result.Append($"  Color: n/a");
            }
            else
            {
                result.Append($"  Color: {Color}");
            }

            return result.ToString();
        }
    }
}
