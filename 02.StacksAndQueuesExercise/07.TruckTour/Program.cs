using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumpsInfo = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] pump = Console.ReadLine()
                            .Split()    
                            .Select(int.Parse)
                            .ToArray();

                pumpsInfo.Enqueue(pump);
            }
            
            int index = 0;
            while (true)
            {
                int sum = 0;
                foreach (int[] pump in pumpsInfo)
                {
                    int fuel = pump[0];
                    int distance = pump[1];
                    sum += fuel - distance;
                    if (sum < 0)
                    {
                        pumpsInfo.Enqueue(pumpsInfo.Dequeue());
                        index++;
                        break;
                    }
                }
                if (sum > 0)
                {
                    Console.WriteLine(index);
                    //Console.WriteLine(sum);
                    return;
                }
            }
        }
    }
}
