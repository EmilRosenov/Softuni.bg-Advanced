using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.

            int n = int.Parse(Console.ReadLine());
            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();
                int query = numbers[0];
                if (query==1)
                {
                    int element = numbers[1];
                    stackNumbers.Push(element);
                }
                else if (query == 2)
                {
                    if (stackNumbers.Count > 0)
                    {
                        stackNumbers.Pop();
                    }
                    
                }
                else if (query == 3)
                {
                    if (stackNumbers.Count>0)
                    {
                        Console.WriteLine(stackNumbers.Max());
                    }
                }
                else if (query == 4)
                {
                    if (stackNumbers.Count > 0)
                    {
                        Console.WriteLine(stackNumbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stackNumbers));
            
        }
    }
}
