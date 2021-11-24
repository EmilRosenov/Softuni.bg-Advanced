using System;
using System.Linq;

namespace _07.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrix[row] = new int[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = input[col];
                }
            }

            string[] inputCommands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (inputCommands[0] != "END")
            {
                string command = inputCommands[0];

                if (command == "Add")
                {
                    int row = int.Parse(inputCommands[1]);
                    int col = int.Parse(inputCommands[2]);
                    int value = int.Parse(inputCommands[3]);

                    if (row >= matrix.Length || row < 0 || col >= matrix[row].Length || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        inputCommands = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                        continue;
                    }

                    matrix[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(inputCommands[1]);
                    int col = int.Parse(inputCommands[2]);
                    int value = int.Parse(inputCommands[3]);

                    if (row < 0 || col >= matrix[row].Length || row >= matrix.Length || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        inputCommands = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                        continue;
                    }
                    matrix[row][col] -= value;
                }


                inputCommands = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int cols = 0; cols < matrix[row].Length; cols++)
                {
                    Console.Write(matrix[row][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
