using System;
using System.Collections.Generic;

namespace _08.trafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightNumberCarsCanPass = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            string inputInfo = Console.ReadLine();
            int counter = 0;

            while (inputInfo !="end")
            {
                if (inputInfo == "green")
                {
                    for (int i = 0; i < greenLightNumberCarsCanPass; i++)
                    {
                        if (carsQueue.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        counter++;
                        
                    }
                }
                else
                {
                    carsQueue.Enqueue(inputInfo);
                }
                inputInfo = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
