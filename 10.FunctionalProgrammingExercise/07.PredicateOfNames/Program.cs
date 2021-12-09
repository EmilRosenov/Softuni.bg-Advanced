using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesMaxLenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<List<string>> printList = collection =>
            Console.WriteLine(string.Join(Environment.NewLine,collection));
            printList(names.Where(x => x.Length <= namesMaxLenght).ToList());
        }
    }
}
