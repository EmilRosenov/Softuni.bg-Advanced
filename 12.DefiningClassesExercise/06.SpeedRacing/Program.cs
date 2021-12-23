using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
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
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                carList.Add(car);    
            }

            string[] inputTwo = Console.ReadLine().Split();
            while (inputTwo[0] !="End")
            {
                string model = inputTwo[1];
                double amountKmToDrive = double.Parse(inputTwo[2]);

                foreach (Car car in carList)
                {
                    if (car.Model==model)
                    {
                        car.CanDrive(amountKmToDrive);
                    }
                }


                inputTwo = Console.ReadLine().Split();
            }

            foreach (Car car in carList)
            {

                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
                
            }
        }
    }
}
