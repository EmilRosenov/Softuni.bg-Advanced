using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int number = int.Parse(Console.ReadLine());

            Func<int, int, bool> isDivisible = (element, number) => element % number == 0;
           

            Action<List<int>> print = something =>
            Console.WriteLine(string.Join(" ", something));
            print(collection.Where(x=>!isDivisible(x, number)).Reverse().ToList());


        }
    }
}
