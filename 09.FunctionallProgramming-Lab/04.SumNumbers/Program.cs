using System;
using System.Linq;

namespace _04.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int sum = line.Sum();
            int count = line.Length;
            Console.WriteLine(count);
            Console.WriteLine(sum);

        }
    }
}
