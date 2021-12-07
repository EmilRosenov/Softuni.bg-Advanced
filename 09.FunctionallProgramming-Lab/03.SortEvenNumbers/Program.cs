using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> evenList = new List<int>();
            foreach (int element in line)
            {
                if (element % 2 ==0)
                {
                    evenList.Add(element);
                }
            }
            Console.WriteLine(string.Join(", ",evenList.OrderBy(x=>x)));
        }
    }
}
