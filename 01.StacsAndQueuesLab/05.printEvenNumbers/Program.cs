using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.printEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);
            // Queue<int> evenNumbersQueue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (queue.Peek() %2 !=0)
                {
                    queue.Dequeue();
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
          
            Console.Write(string.Join(", ", queue));
            Console.WriteLine();
        }
    }
}
