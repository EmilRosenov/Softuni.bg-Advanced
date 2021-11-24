using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = CreateMatrix(n);
            int primarySum = 0;
            primarySum = PrintPrimarySum(n, matrix, primarySum);
         
        }

        private static int PrintPrimarySum(int n, int[,] matrix, int primarySum)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    primarySum += matrix[i, j];
                    break;
                }
            }
            Console.WriteLine(primarySum);
            return primarySum;
        }

        private static int[,] CreateMatrix(int n)
        {
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = ReadArrayFromConsole();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            return matrix;
        }

        static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
