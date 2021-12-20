using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Tire[]> tiresList = new List<Tire[]>();
            while (input != "No more tires")
            {
                string[] tyresInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int firstTireYear = int.Parse(tyresInput[0]);
                double firstTirePressure = double.Parse(tyresInput[1]);
                int secondTireYear = int.Parse(tyresInput[2]);
                double secondTirePressure = double.Parse(tyresInput[3]);
                int thirdTireYear = int.Parse(tyresInput[4]);
                double thirdTirePressure = double.Parse(tyresInput[5]);
                int fourthTireYear = int.Parse(tyresInput[6]);
                double fourthTirePressure = double.Parse(tyresInput[7]);


                tiresList.Add(new Tire[]
                {
                    new Tire(firstTireYear, firstTirePressure),
                    new Tire(secondTireYear, secondTirePressure),
                    new Tire(thirdTireYear, thirdTirePressure),
                    new Tire(fourthTireYear, fourthTirePressure),
                });

                input = Console.ReadLine();
            }

            string anotherInput = Console.ReadLine();
            List<Engine> enginesList = new List<Engine>();

            while (anotherInput!="Engines done")
            {
                string[] array = anotherInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int horsePower = int.Parse(array[0]);
                double cubicCapacity = double.Parse(array[1]);

                enginesList.Add(new Engine(horsePower, cubicCapacity));
                

                anotherInput = Console.ReadLine();
            }

            string thirdInput = Console.ReadLine();
            List<Car> specialCars = new List<Car>();

            while (thirdInput!= "Show special")
            {
                string[] arr = thirdInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string make = arr[0];
                string model = arr[1];
                int year = int.Parse(arr[2]);
                double fuelQuantity = double.Parse(arr[3]);
                double fuelConsumption = double.Parse(arr[4]);
                Engine currentEngine = enginesList[int.Parse(arr[5])];
                Tire[] currentTire = tiresList[int.Parse(arr[6])];

                specialCars.Add(new Car(make, model, year,
                                        fuelQuantity,
                                        fuelConsumption,
                                        currentEngine,
                                        currentTire));

                thirdInput = Console.ReadLine();
            }

            for (int i = 0; i < specialCars.Count; i++)
            {
                bool tiresPressure = specialCars[i].Sum(specialCars[i].Tires) >= 9 && specialCars[i].Sum(specialCars[i].Tires) <= 10;
                if (specialCars[i].Year < 2017 || specialCars[i].Engine.HorsePower < 330 || tiresPressure == false)
                {
                    specialCars.RemoveAt(i);
                    i--;
                }
            }
            foreach (Car car in specialCars)
            {
                car.FuelQuantity = car.FuelQuantity - (car.FuelConsumption  *0.2);
            }
            foreach (Car car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}

