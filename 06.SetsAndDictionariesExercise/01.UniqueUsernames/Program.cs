using System;
using System.Collections.Generic;

namespace _06.SetsAndDictionariesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                list.Add(username);
            }
            foreach (var item in list)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
