using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class Program
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
                List<Tire> tires = new List<Tire>(); 

                for (int j = 5; j < input.Length; j+=2)
                {
                    Tire tire = new Tire(double.Parse(input[j]), int.Parse(input[j+1]));
                    tires.Add(tire);
                }
                Car car = new Car(model, engine, cargo, tires);
                carList.Add(car);
            }

            string singleLine = Console.ReadLine();

            if (singleLine == "flammable")
            {
                var flammableCars = carList.Where(x => x.Cargo.Type == "flammable"
                                          && x.Engine.Power > 250);
                foreach (Car car in flammableCars)
                {
                    Console.WriteLine(car.Model);
                }

            }
            else if (singleLine == "fragile")
            {
                var fragileCars = carList.Where(x => x.Cargo.Type == "fragile"
                            && x.Tires.Any(p => p.Pressure < 1));

                foreach (Car car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }

            }
        }
    }
}
