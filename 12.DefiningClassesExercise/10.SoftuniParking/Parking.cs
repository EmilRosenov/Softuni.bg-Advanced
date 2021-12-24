using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
   public class Parking
    {
        private int capacity;
        private Dictionary<string, Car> cars;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new Dictionary<string, Car>();

        }
        public int Count
           => cars.Count;

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count ==  capacity)
            {
                return "Parking is full!";
            }

            cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}"; 
        }
        public string RemoveCar(string registrationNr)
        {
            if (!cars.ContainsKey(registrationNr))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(registrationNr);
            return $"Successfully removed {registrationNr}";
        }
        public Car GetCar(string registrationNr)
        {
            return cars[registrationNr];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var reg in registrationNumbers)
            {
                cars.Remove(reg);
            }
        }
       
    }
}
