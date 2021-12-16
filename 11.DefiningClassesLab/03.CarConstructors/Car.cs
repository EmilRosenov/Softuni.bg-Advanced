using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {

        }
        public Car(string make, string model, int year)
        : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year,
                    double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make { get; private set; } = "VW";

        public string Model { get; private set; } = "Golf";

        public int Year { get; private set; } = 2025;

        public double FuelQuantity { get; private set; } = 200;

        public double FuelConsumption { get; private set; } = 10;
       
        public void Drive(double distance)
        {
            bool isEnough = fuelQuantity - (distance * fuelConsumption) >= 0;

            if (isEnough)
            {
                double distanceCovered = fuelQuantity - (distance * fuelConsumption);
                Console.WriteLine(distanceCovered);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.make}");
            sb.AppendLine($"Model: {this.model}");
            sb.AppendLine($"Year: {this.year}");
            sb.AppendLine($"Fuel: {this.fuelQuantity:f2}");
            return sb.ToString();
        }

       
    }
}
