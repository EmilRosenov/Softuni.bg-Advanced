using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = lenghts[0];
            int m = lenghts[1];

            var first = new HashSet<int>();
            var second = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                first.Add(numbers);
            }

            for (int i = 0; i < m; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                second.Add(numbers);
            }

            var third = first.Intersect(second);
            Console.WriteLine(string.Join(" ", third));
        }
    }
}
