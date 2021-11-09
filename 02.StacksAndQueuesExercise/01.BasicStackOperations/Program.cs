using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueuesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int[] givenNumbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            Stack<int> stackNumbers = new Stack<int>();
            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            for (int i = 0; i < n; i++)
            {
                stackNumbers.Push(givenNumbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stackNumbers.Pop();
            }

            if (stackNumbers.Count==0)
            {
                Console.WriteLine("0");
            }
            else if (stackNumbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (!stackNumbers.Contains(x))
            {
                Console.WriteLine(stackNumbers.Min());
            }
            
        }
    }
}
