using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupCpacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottleCpacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> botllesStack = new Stack<int>(bottleCpacity);
            Queue<int> cupsQueue = new Queue<int>(cupCpacity);


            //4 2 10 5
            //3 15 15 11 6
            int currentBottleLitres = 0;
            int currentCupCapacity = 0;
            int wastedLitres = 0;
            int sum = 0;

            while (cupsQueue.Count > 0 && botllesStack.Count > 0)
            {

                currentBottleLitres = botllesStack.Peek();
                currentCupCapacity = cupsQueue.Peek();
                if (currentBottleLitres >= currentCupCapacity)
                {
                    sum = currentBottleLitres - currentCupCapacity;
                    wastedLitres += sum;
                    botllesStack.Pop();
                    cupsQueue.Dequeue();
                }

                else 
                {
                    sum = 0;
                    while (currentCupCapacity > sum)
                    {
                        sum += botllesStack.Peek();
                        if (sum >= currentCupCapacity)
                        {
                            wastedLitres += sum - currentCupCapacity;
                            botllesStack.Pop();
                            cupsQueue.Dequeue();
                            break;
                        }
                        botllesStack.Pop();
                    }
                    
                }
            }

                if (botllesStack.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
                }
                else if (cupsQueue.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", botllesStack)}");
                }
                Console.WriteLine($"Wasted litters of water: {wastedLitres}");
            }
        }
    }
