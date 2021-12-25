using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacingMyWayOrTheHighWay
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInput = Console.ReadLine().Split();
                string model = carInput[0];
                double fuelAmount = double.Parse(carInput[1]);
                double fuelConsumptionPe1Km = double.Parse(carInput[2]);
                double killometresTravelled = 0;

                Car car = new Car(model, fuelAmount,
                    fuelConsumptionPe1Km, killometresTravelled);

                cars.Add(model,car);
            }

            string[] input = Console.ReadLine().Split();
            while (input[0]!="End")
            {
                string model = input[1];
                double amountKm = double.Parse(input[2]);

                if (cars.ContainsKey(model))
                {
                    cars[model].Drive(cars[model], amountKm);
                }

                input = Console.ReadLine().Split();
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
