using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ReadArrayFromConsole();

            int[,] matrix = new int[input[0], input[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] array = ReadArrayFromConsole();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            int sum = 0;
            foreach (int element in matrix)
            {
                sum += element;
            }
            Console.WriteLine(sum);

            static int[] ReadArrayFromConsole()
            {
                return Console.ReadLine()
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            }
        }
    }
}
