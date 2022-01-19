using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> parkingList;
        //private  string type;
        //private  int capacity;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            parkingList = new List<Car>(capacity);
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return parkingList.Count; } }

        public void Add(Car car)
        {
            if (parkingList.Count < Capacity)
            {
                parkingList.Add(car);
            }

        }
        public bool Remove(string manufacturer, string model)
        {
            var carToRemove = parkingList.Where(x => x.Manufacturer == manufacturer
                              && x.Model == model);
            if (parkingList.Contains(carToRemove.FirstOrDefault()))
            {
                parkingList.Remove(carToRemove.FirstOrDefault());
                return true;
            }
            return false;
        }
        public Car GetLatestCar()
        {
            parkingList = parkingList.OrderByDescending(x => x.Year).ToList();
            var latest = parkingList.FirstOrDefault();
            if (parkingList.Count == 0)
            {
                return null;
            }
            return latest;
        }

        public Car GetCar(string manufacturer, string model)
        {
            var getCar = parkingList.Where(x => x.Manufacturer == manufacturer
                              && x.Model == model);
            if (getCar == null)
            {
                return null;
            }
            return getCar.FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in parkingList)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
