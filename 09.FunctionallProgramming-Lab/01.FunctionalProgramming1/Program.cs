using System;

namespace FunctionalProgramming1
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = Multiply(1, 2);
            Console.WriteLine(result);

            Func<int, int, long> func = Multiply;
           //Console.WriteLine(func(5, 6));
           //Console.WriteLine(func(7, 9));
           //Console.WriteLine(func(6, 8));
           //Console.WriteLine(func(2, 5));
           //Console.WriteLine(func(9, 3));
           //Console.WriteLine(func(4, 7));
            PrintResult(1,2, func);

            func = Sum;
            //Console.WriteLine(func(5, 6));
            //Console.WriteLine(func(7, 9));
            //Console.WriteLine(func(6, 8));
            //Console.WriteLine(func(2, 5));
            //Console.WriteLine(func(9, 3));
            //Console.WriteLine(func(4, 7));
            PrintResult(1, 2, func);



        }
        static void PrintResult(int a, int b, Func<int,int,long> func)
        {
            for (int i = 0; i < 5; i++)
            {
                var result = func(a+i, b+i);
                Console.WriteLine(new string ('=',50));
                Console.WriteLine($"Result: {result}");
                Console.WriteLine(new string ('=',50));
            }
            
        }
        static long Multiply(int a, int b)
        {
            return a * b;
        }

        static long Sum(int a, int b) 
        {
            return a + b;
        }
    }
}
