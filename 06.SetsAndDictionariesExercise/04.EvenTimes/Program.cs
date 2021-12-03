using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var occurances = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();
                if (!occurances.ContainsKey(number))
                {
                    occurances.Add(number, 0);
                }
                occurances[number]++;
            }

            foreach (var item in occurances)
            {
                if (item.Value%2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
