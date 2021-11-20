using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int againGreen = greenLightDuration;
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> carQueue = new Queue<string>();

            string input = Console.ReadLine();

            int counter = 0;
            string car = "";
            string nextCar = "";

            while (input != "END")
            {
                if (input == "green")
                {
                    int sum = 0;
                    greenLightDuration = againGreen;
                    while (greenLightDuration > 0 && carQueue.Count>0)
                    {
                        car = carQueue.Peek();
                        if (greenLightDuration >= car.Length)
                        {
                            greenLightDuration -= car.Length;
                            carQueue.Dequeue();
                            counter++;
                        }
                        else if (greenLightDuration > 0)
                        {
                            sum = greenLightDuration + freeWindow;
                            if (sum > car.Length )
                            {
                                sum -= car.Length;
                                greenLightDuration = 0;
                                carQueue.Dequeue();
                                counter++;
                            }
                            else
                            {
                                Console.WriteLine($"A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[greenLightDuration + freeWindow]}.");
                                return;
                            }
                        }
                        else if (greenLightDuration <= 0)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
