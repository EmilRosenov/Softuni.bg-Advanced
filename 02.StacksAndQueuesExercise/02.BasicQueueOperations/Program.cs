using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
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
            Queue<int> queueNumbers = new Queue<int>();
            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            for (int i = 0; i < n; i++)
            {
                queueNumbers.Enqueue(givenNumbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queueNumbers.Dequeue();
            }

            if (queueNumbers.Count==0)
            {
                Console.WriteLine("0");
            }
            else if (queueNumbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (!queueNumbers.Contains(x))
            {
                Console.WriteLine(queueNumbers.Min());
            }
        }
    }
}
