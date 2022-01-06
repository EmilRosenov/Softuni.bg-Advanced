using System;

namespace _05.GenericCountMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            string comparer = Console.ReadLine();
            Console.WriteLine(box.GetGenericCount(comparer));
            
        }
    }
}
