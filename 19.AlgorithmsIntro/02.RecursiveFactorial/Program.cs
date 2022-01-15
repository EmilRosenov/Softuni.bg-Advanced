using System;

namespace _02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = GetFactorial(n);
            Console.WriteLine(factorial);
        }

        private static int GetFactorial(int n)
        {
            if (n==0)
            {
                return 1;
            }
            int result = n * GetFactorial(n - 1);
            return result;
        }
    }
}
