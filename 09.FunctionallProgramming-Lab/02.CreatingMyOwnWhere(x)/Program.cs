using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CreatingMyOwnWhere_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newList = list.Where(EvenNumbers);
            Console.WriteLine(string.Join(", ", newList));

            var newList2 = Where2(list, OddNumbers);
            Console.WriteLine(string.Join(", ", newList2));

        }

        private static bool OddNumbers(int x)
        {
            return x % 2 != 0;
        }

        static List<int> Where2(List<int> list, Func<int,bool> condition)
        {
            List<int> newList2 = new List<int>();

            foreach (var item in list)
            {
                if (condition(item))
                {
                    newList2.Add(item);
                }
            }

            return newList2;
        }

        static bool EvenNumbers(int number)
        {
            return number % 2 == 0;
        }
    }
}
