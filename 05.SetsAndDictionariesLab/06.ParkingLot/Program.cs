using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var register = new HashSet<string>();
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0]=="END")
                {
                    if (register.Count<=0)
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, register));
                        
                    }
                    return;
                }

                string enterOrLeave = input[0];
                string numberPlate = input[1];

                if (enterOrLeave=="IN")
                {
                    register.Add(numberPlate);
                }
                else if (enterOrLeave == "OUT")
                {
                    register.Remove(numberPlate);
                }
            }
        }
    }
}
