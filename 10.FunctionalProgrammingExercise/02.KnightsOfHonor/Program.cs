using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            List<string> namesList = new List<string>();
            foreach (var name in names)
            {
                namesList.Add(name);
            }

            Action<List<string>> appendSir =
                namesList => namesList.ForEach(x => Console.WriteLine("Sir " + (x)));
            appendSir(namesList);
        }
    }
}
