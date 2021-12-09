using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvenOrOddWithWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            string inputEvenOrOdd = Console.ReadLine();
            Predicate<int> isEven = number => number % 2 == 0;
            List<int> list = new List<int>();
            Action<int[]> printNumbers = list
                => Console.WriteLine(string.Join(" ", list));

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                list.Add(i);
            }

            if (inputEvenOrOdd == "even")
            {
                printNumbers(list.Where(x => isEven(x)).ToArray());
            }
            else
            {
                printNumbers(list.Where(x => !isEven(x)).ToArray());
            }

        }
    }
}
