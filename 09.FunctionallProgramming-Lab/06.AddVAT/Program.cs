using System;
using System.Linq;

namespace _06.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            var numbersWithVAT = numbers.Select(number => number * 1.2);
            foreach (var number in numbersWithVAT)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}
