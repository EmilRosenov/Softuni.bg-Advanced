using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Action<int[]> printCollection = numbers =>
            Console.WriteLine(string.Join(" ", numbers));

            Func<int, int> addOne = element =>
            {
                element = element + 1;
                return element;
            };
            Func<int, int> multiplyBy2 = element =>
             {
                 int result = element * 2;
                 return result;
             };
            Func<int, int> subtractOne = element =>
            {
                element = element - 1;
                return element;
            };


            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end")
                {
                    return;
                }

                if (command =="add")
                {
                    input = input.Select(addOne).ToArray();
                }
                else if (command== "multiply")
                {
                    input = input.Select(multiplyBy2).ToArray();
                }
                else if (command == "subtract")
                {
                    input = input.Select(subtractOne).ToArray();
                }
                else if (command == "print")
                {
                    printCollection(input);
                }
            }
        }
    }
}
