using System;
using System.Linq;

namespace _08.Bombs100100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string[] bombs = Console.ReadLine().Split();

            for (int i = 0; i < bombs.Length; i++)
            {
                string[] currBombcoordinates = bombs[i].Split(",");
                int bombrow = int.Parse(currBombcoordinates[0]);
                int bombcol = int.Parse(currBombcoordinates[1]);
                int bombPower = matrix[bombrow, bombcol]; // value of the current bomb

                if (bombPower > 0)// Check if current bomb have positive value !
                {
                    //-1,-1
                    if (IsInside(matrix, bombrow - 1, bombcol - 1) && matrix[bombrow - 1, bombcol - 1] > 0 //&&
                        )//matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow - 1, bombcol - 1] -= bombPower;
                    }
                    //-1,0
                    if (IsInside(matrix, bombrow - 1, bombcol) && matrix[bombrow - 1, bombcol] > 0 //&&
                       )// matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow - 1, bombcol] -= bombPower;
                    }
                    //-1,+1
                    if (IsInside(matrix, bombrow - 1, bombcol + 1) && matrix[bombrow - 1, bombcol + 1] > 0 //&&
                       )// matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow - 1, bombcol + 1] -= bombPower;
                    }
                    //0,+1
                    if (IsInside(matrix, bombrow, bombcol + 1) && matrix[bombrow, bombcol + 1] > 0 //&&
                        )//matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow, bombcol + 1] -= bombPower;
                    }
                    //+1,+1
                    if (IsInside(matrix, bombrow + 1, bombcol + 1) && matrix[bombrow + 1, bombcol + 1] > 0 //&&
                       )// matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow + 1, bombcol + 1] -= bombPower;
                    }
                    //+1,0
                    if (IsInside(matrix, bombrow + 1, bombcol) && matrix[bombrow + 1, bombcol] > 0 //&&
                       )// matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow + 1, bombcol] -= bombPower;
                    }
                    //+1,-1
                    if (IsInside(matrix, bombrow + 1, bombcol - 1) && matrix[bombrow + 1, bombcol - 1] > 0 //&&
                       )// matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow + 1, bombcol - 1] -= bombPower;
                    }
                    //0,-1
                    if (IsInside(matrix, bombrow, bombcol - 1) && matrix[bombrow, bombcol - 1] > 0 //&&
                       )// matrix[bombrow, bombcol] > 0)
                    {
                        matrix[bombrow, bombcol - 1] -= bombPower;
                    }

                    matrix[bombrow, bombcol] = 0;
                }

            }

            int counter = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        counter++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
        private static bool IsInside(int[,] matrix, int bombrow, int bombcol)
        {
            return bombrow >= 0 && bombrow < matrix.GetLength(0) &&
                bombcol >= 0 && bombcol < matrix.GetLength(1);
        }
    }
}
