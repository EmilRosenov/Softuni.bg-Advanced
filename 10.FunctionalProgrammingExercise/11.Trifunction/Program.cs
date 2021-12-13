using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Trifunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> isBigger = (name, asciiSum) => name.Sum(x => x) >= asciiSum;
            Func<List<string>,int, Func<string, int, bool>, string> desired = (names,n, func)
                => names.FirstOrDefault(x => func(x, n));
            string name = desired(names, n, isBigger);

            Console.WriteLine(name); 
        }
    }
}
