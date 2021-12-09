using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            Func<int[], int> smallestInteger = line=>
            {
                int minValue = int.MaxValue;

                foreach (var item in line)
                {
                    if (item<minValue)
                    {
                        minValue = item;
                    }
                }
                return minValue;
            };
            Console.WriteLine(smallestInteger(line));
        }
    }
}
