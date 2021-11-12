using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.fastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityPrepared = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            Queue<int> ordersQueue = new Queue<int>(orders);

            int biggestOrder = ordersQueue.Max();

            Console.WriteLine(biggestOrder);

            for (int i = 0; i < orders.Length; i++)
            {
                if (quantityPrepared >= ordersQueue.Peek())
                {
                    quantityPrepared -= ordersQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (ordersQueue.Count>0)
            {
                Console.WriteLine("Orders left: " + $"{string.Join(" ", ordersQueue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
