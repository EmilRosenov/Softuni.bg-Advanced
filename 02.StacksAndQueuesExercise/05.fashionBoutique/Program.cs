using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.fashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceIntigers = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

            Stack<int> numbers = new Stack<int>(sequenceIntigers);

            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0; ;

            while (numbers.Count>0)
            {
                int current = numbers.Peek();
                if (sum+current < rackCapacity)
                {
                    sum += numbers.Pop();
                }
                else if (sum+current==rackCapacity)
                {
                    counter++;
                    sum = 0;
                    numbers.Pop();
                }
                else if (sum + current > rackCapacity)
                {
                    counter++;
                    sum = 0;
                }
               
            }
            if (sum>0)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
