using System;
using System.Linq;

namespace MultIDimensionalArraysEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            FillUpMatrix(matrix);
            
            int primarySum = 0;
            int secondarySum = 0;

            primarySum = SumPrimaryDiagonal(matrix, primarySum);
            secondarySum = SumSecondaryDiagonal(matrix, secondarySum);
            int difference = primarySum - secondarySum;
            Console.WriteLine(Math.Abs(difference));

        }

        private static int SumSecondaryDiagonal(int[,] matrix, int secondarySum)
        {
            int row = 0;
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                secondarySum += matrix[row, col];
                row++;

            }

            return secondarySum;
        }

        private static int SumPrimaryDiagonal(int[,] matrix, int primarySum)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    primarySum += matrix[i, j];
                    break;
                }
            }

            return primarySum;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillUpMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
