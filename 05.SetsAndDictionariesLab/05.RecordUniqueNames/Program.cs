using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var namesList = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                namesList.Add(name);
            }

            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
