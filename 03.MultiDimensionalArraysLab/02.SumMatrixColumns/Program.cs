using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ReadArrayFromConsole();

            int[,] matrix = new int[array[0], array[1]];

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                int[] input = ReadArrayFromConsole();
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {   int element = matrix[row, col];
                    sum += element;
                }
                Console.WriteLine(sum);
            }

        }


        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
