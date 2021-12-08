using System;
using System.Linq;

namespace _04.SumNumbersWithMyOwnParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(MyParse)
                .ToArray();
            
            Console.WriteLine(line.Length);
            Console.WriteLine(line.Sum());
        }
        static int MyParse(string numberAsString)
        {
            int number = 0;
            foreach (var digit in numberAsString)
            {
                number *= 10;
                number += (digit - '0');
            }

            return number;
        }
    }
}
