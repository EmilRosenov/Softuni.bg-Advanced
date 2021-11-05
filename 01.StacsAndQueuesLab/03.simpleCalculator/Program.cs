using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> numbers = new Stack<string>();

            int sum = 0;
            foreach (string item in input.Reverse().ToArray())
            {
                numbers.Push(item);
                //sum += int.Parse(item);
            }
            
            while (numbers.Count > 1)
            {
                int a = int.Parse(numbers.Pop());
                string op = numbers.Pop();
                int b = int.Parse(numbers.Pop());

                if (op=="+")
                {
                    numbers.Push((a + b).ToString());
                }
                else
                {
                    numbers.Push((a - b).ToString());
                }
            }

            Console.WriteLine(numbers.Pop());
            
        }
    }
}
