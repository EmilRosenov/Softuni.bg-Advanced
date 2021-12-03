using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var occurances = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (!occurances.ContainsKey(current))
                {
                    occurances.Add(current,0);
                }
                occurances[current]++;
            }

            foreach (var item in occurances.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
