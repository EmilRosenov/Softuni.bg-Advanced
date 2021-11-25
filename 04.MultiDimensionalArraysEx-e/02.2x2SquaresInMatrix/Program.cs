using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            FillMatrix(matrix);
            //Console.WriteLine("-----------------");
            //PrintMatrix(matrix);

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (AreEqual(matrix, row, col))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        private static bool AreEqual(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == matrix[row, col + 1] &&
                   matrix[row, col] == matrix[row + 1, col] &&
                   matrix[row, col] == matrix[row + 1, col];
                    
        }

        private static void PrintMatrix(char[,]matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
            
        }

        private static void FillMatrix(char[,]matrix)
        {
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
