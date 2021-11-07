using System;
using System.Collections.Generic;

namespace _06.supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputInfo = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (inputInfo != "End")
            {

                if (inputInfo == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(inputInfo);
                }
                inputInfo = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
