using System;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake path = new Lake(input);
            Console.WriteLine(string.Join(", ",path));
        }
    }
}
