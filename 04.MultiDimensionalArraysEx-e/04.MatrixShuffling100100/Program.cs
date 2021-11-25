using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int numberRows = inputNumbers[0];
            int numberCols = inputNumbers[1];

            string[,] matrix = ReadMatrix(numberRows, numberCols);

            while (true)
            {
                string[] commandInput = Console.ReadLine().Split(" ").ToArray();


                if (commandInput[0] == "END")
                {
                    return;
                }


                if (commandInput.Length == 5
                    && commandInput[0] == "swap"
                    && int.Parse(commandInput[1]) < numberRows
                    && int.Parse(commandInput[2]) < numberCols)
                {
                    int firtsRow = int.Parse(commandInput[1]);
                    int firtsCol = int.Parse(commandInput[2]);
                    int secondRow = int.Parse(commandInput[3]);
                    int secondCol = int.Parse(commandInput[4]);


                    string temp = matrix[firtsRow, firtsCol];
                    matrix[firtsRow, firtsCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = temp;

                    PrintMatrix(matrix);
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }


        }

        public static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;

        }

        static void PrintMatrix(string[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
