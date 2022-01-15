using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = SumArray(integers,0);
            Console.WriteLine(sum);
        }

        private static int SumArray(int[] integers,int index)
        {
            if (index==integers.Length)
            {
                return 0;
            }
            return integers[index] + SumArray(integers, index + 1);
        }
    }
}
