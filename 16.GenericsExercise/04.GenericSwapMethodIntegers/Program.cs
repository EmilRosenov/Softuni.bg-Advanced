using System;
using System.Linq;

namespace _04.GenericSwapMethodIntegers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
            }

            int[] inputSwap = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();
            int first = inputSwap[0];
            int second = inputSwap[1];

            box.Swap(first, second);
            Console.WriteLine(box);
        }
    }
}
