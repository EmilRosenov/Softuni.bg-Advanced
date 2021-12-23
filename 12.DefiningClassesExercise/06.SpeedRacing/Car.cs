using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        List<Car> list = new List<Car>();


        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }


        public void CanDrive(double amountKmToDrive)
        {
            bool candrive = FuelAmount - (FuelConsumptionPerKilometer * amountKmToDrive) >= 0;

            if (candrive)
            {
                FuelAmount -= FuelConsumptionPerKilometer * amountKmToDrive;
                TravelledDistance += amountKmToDrive;

            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");

            }

        }
    }
}