using System;

namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }
            double comparer = double.Parse(Console.ReadLine());
            Console.WriteLine(box.GetGenericCount(comparer));

        }
    }
}
