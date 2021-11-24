using System;
using System.Linq;

namespace _04.SecondaryDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = CreateMatrix(n);
            int secondarySum = 0;
            secondarySum = PrintSecondarySum(matrix, secondarySum);

        }
        static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
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
        private static int PrintSecondarySum(int[,] matrix, int secondarySum)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1 - row; col >= 0; col--)
                {

                    int element = matrix[row, col];
                    secondarySum += element;
                    break;
                }

            }

            Console.WriteLine(secondarySum);
            return secondarySum;
        }
    }
}
