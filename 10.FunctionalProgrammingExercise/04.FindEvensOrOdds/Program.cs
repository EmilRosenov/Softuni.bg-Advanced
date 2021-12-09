using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
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
            Action<List<int>> printNumbers = list
                => Console.WriteLine(string.Join(" ",list));

            if (inputEvenOrOdd=="even")
            {
                for (int i = numbers[0]; i <= numbers[1]; i++)
                {
                    if (isEven(i))
                    {
                        list.Add(i);
                    }

                }
            }
            else
            {
                for (int i = numbers[0]; i <= numbers[1]; i++)
                {
                    if (!isEven(i))
                    {
                        list.Add(i);
                    }

                }
            }

            printNumbers(list);
        }
    }
}
