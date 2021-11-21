using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);
           

            int counter = 0;


            while (locksQueue.Count > 0 && bulletsStack.Count > 0)
            {
                
                if (bulletsStack.Peek() <= locksQueue.Peek())
                {
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                    counter++;
                    intelligenceValue -= bulletPrice;
                    Console.WriteLine("Bang!");

                    if (counter == gunBarrelSize && bulletsStack.Count>0)
                    {
                        Console.WriteLine("Reloading!");
                        counter = 0;
                    }
                }
                else if (bulletsStack.Peek() > locksQueue.Peek())
                {
                    bulletsStack.Pop();
                    counter++;
                    intelligenceValue -= bulletPrice;
                    Console.WriteLine("Ping!");

                    if (counter == gunBarrelSize && bulletsStack.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        counter = 0;
                    }
                }

               
            }

            if (bulletsStack.Count == 0 && locksQueue.Count == 0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligenceValue}");
            }
            else if (bulletsStack.Count==0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else if (locksQueue.Count == 0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligenceValue}");
                
            }
           
        }
    }
}
