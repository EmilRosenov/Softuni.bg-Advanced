using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{

    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

    }
    public class Tire
    {
        private int year;
        private double pressure;

        public int Year { get; set; }
        public double Pressure { get; set; }
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire tires;

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

        public Car(string make, string model, int year,
                    double fuelQuantity,
                    double fuelConsumption,
                    Engine engine,
                    Tire[] tires)

        : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            Engine = engine;
            Tires = tires;
        }

        public string Make { get; private set; } = "VW";

        public string Model { get; private set; } = "Golf";

        public int Year { get; private set; } = 2025;

        public double FuelQuantity { get; set; } = 200;

        public double FuelConsumption { get; set; } = 10;

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

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

        public double Sum(Tire[] tires)
        {
            double sum = 0;
            foreach (Tire tire in this.Tires)
            {
                sum += tire.Pressure;
            }
            return sum;
        }
    }
}
