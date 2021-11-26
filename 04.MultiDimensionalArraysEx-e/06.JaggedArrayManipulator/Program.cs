using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{

    class Program
    {


        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedMatix = new double[rows][];
            PopulateJaggedMatrix(jaggedMatix);

            ManipulateMatrix(jaggedMatix);

            for (int row = 0; row < rows; row++)
            {
                for (int cols = 0; cols < jaggedMatix[row].Length; cols++)
                {
                    Console.Write(jaggedMatix[row][cols] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ManipulateMatrix(double[][] jaggedMatix)
        {
            while (true)
            {
                string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                string command = input[0];

                if (command == "Add")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    double valueToAdd = double.Parse(input[3]);

                    if (IsValid(row, col, jaggedMatix))
                    {
                        jaggedMatix[row][col] += valueToAdd;
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    double valueToSubtrackt = double.Parse(input[3]);

                    if (IsValid(row, col, jaggedMatix))
                    {
                        jaggedMatix[row][col] -= valueToSubtrackt;
                    }
                }

            }
        }

        private static bool IsValid(int row, int col, double[][] jagged)
        {
            return row >= 0 && row < jagged.GetLength(0) &&
                   col >= 0 && col < jagged[row].Length;

        }

        private static double[][] PopulateJaggedMatrix(double[][] jaggedMatix)
        {
            //int[][] jaggedMatix = new int[rows][];
            for (int row = 0; row < jaggedMatix.GetLength(0); row++)
            {
                jaggedMatix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            }

            for (int rowes = 0; rowes < jaggedMatix.GetLength(0)-1; rowes++)
            {

                if (jaggedMatix[rowes].Length == jaggedMatix[rowes + 1].Length)
                {
                    for (int cols = 0; cols < jaggedMatix[rowes].Length; cols++)
                    {
                        jaggedMatix[rowes][cols] *= 2;
                        jaggedMatix[rowes + 1][cols] *= 2;
                    }
                }
                else
                {
                    for (int colls = 0; colls < jaggedMatix[rowes].Length; colls++)
                    {
                        jaggedMatix[rowes][colls] /= 2;
                    }
                    for (int colss = 0; colss < jaggedMatix[rowes + 1].Length; colss++)
                    {
                        jaggedMatix[rowes + 1][colss] /= 2;

                    }
                }
            }
            return jaggedMatix;
        }
    }
}
