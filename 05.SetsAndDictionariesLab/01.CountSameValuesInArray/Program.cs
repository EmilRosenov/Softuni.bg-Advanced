using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SetsAndDictionariesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] innput = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var occurances = new Dictionary<double, int>();

            foreach (var item in innput)
            {
                if (!occurances.ContainsKey(item))
                {
                    occurances.Add(item, new int());
                }
                occurances[item]++;
            }

            foreach (var (dKey, iValue) in occurances)
            {
                Console.WriteLine($"{dKey} - {iValue} times");
            }
        }
    }
}
