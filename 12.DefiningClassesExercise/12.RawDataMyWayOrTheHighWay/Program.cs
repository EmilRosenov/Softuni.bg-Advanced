using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.RawDataMyWayOrTheHighWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                List<Tire> tires = new List<Tire>(4);

                for (int j = 5; j < input.Length; j+=2)
                {
                    double tirePressure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j + 1]);
                    Tire tire = new Tire(tirePressure, tireAge);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);
                carList.Add(car);
            }

            string word = Console.ReadLine();

            if (word == "fragile")
            {
                var sorted = carList.FindAll(x => x.Cargo.Type == word && x.Tires.Exists(x => x.TirePressure < 1)).ToList();
                foreach (Car car in sorted)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (word== "flammable")
            {
                var sorted = carList.FindAll(x => x.Cargo.Type == word && x.Engine.EnginePower > 250).ToList();
                foreach (Car car in sorted)
                {
                    Console.WriteLine(car.Model);
                }
            }

           
        }
    }
}
