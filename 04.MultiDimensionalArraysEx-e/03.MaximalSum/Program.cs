using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ReadIntegerArray();

            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            Initialize(matrix);
            Console.WriteLine("----");
            PrintMatrix(matrix);
            
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            while (true)
            {
                
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0)-2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1)-2; col++)
                    {
                        if (IsInside(matrix))
                        {
                            sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        }

                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestRow = row;
                            bestCol = col;
                        }

                    }
                }

                break;
            }
            
            Console.WriteLine(bestSum);

            for (int row = bestRow; row <= bestRow + 2; row++)
            {
                for (int col = bestCol; col <= bestCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        private static bool IsInside(int[,] matrix)
        {
            int row = 0;
            int col = 0;
            return row + 2 <= matrix.GetLength(0) && row >= 0
                   && col + 2 < matrix.GetLength(1) && col >= 0;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            

        }
        private static int[] ReadIntegerArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        private static void Initialize(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] integers = ReadIntegerArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = integers[cols];
                }
            }
        }
    }
}
