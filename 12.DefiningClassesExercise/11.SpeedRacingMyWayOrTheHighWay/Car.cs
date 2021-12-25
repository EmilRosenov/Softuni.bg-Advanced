using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacingMyWayOrTheHighWay
{
    public class Car
    {
        public Car(string model, double fuelAmount,
                   double fuelConsumptionPerKilometer, 
                   double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = travelledDistance;
        }

        //•	string Model
        //•	double FuelAmount
        //•	double FuelConsumptionPerKilometer
        //•	double Travelled distance
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; } = 0;


        public void Drive(Car car, double amountToDrive)
        {
            
            bool canMove = car.FuelAmount - (car.FuelConsumptionPerKilometer * amountToDrive) >= 0 == true;
            if (!canMove)
            {
                 Console.WriteLine("Insufficient fuel for the drive");
                 return;
            }
            car.FuelAmount -= car.FuelConsumptionPerKilometer * amountToDrive;
            car.TravelledDistance += amountToDrive;
            
        }

    }
}
