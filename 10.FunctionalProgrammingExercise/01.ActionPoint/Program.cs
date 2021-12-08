using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string[]> printResult = input 
                =>  Console.WriteLine(string.Join(Environment.NewLine,input));
            printResult(input);
        }
    }
}
