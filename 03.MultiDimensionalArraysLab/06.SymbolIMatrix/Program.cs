using System;
using System.Linq;

namespace _06.SymbolIMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int bestRow = int.MinValue;
            int bestCol = int.MinValue;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string input = Console.ReadLine();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    char element = char.Parse(input[cols].ToString());
                    matrix[rows, cols] = element;
                }
            }

            char elementTwo = char.Parse(Console.ReadLine());

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == elementTwo)
                    {
                        bestRow = rows;
                        bestCol = cols;

                        Console.WriteLine($"({bestRow}, {bestCol})");
                        return;
                    }
                    
                }
            }

            Console.WriteLine($"{elementTwo} does not occur in the matrix");

        }
    }
}
