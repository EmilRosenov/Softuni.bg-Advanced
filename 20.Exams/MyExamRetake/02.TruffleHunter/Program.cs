using System;
using System.Linq;

namespace _02.TruffleHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int blackTruffleCount = 0;
            int summerTruffleCount = 0;
            int whiteTruffleCount = 0;
            int wildBoarEatsCount = 0;

            Initialize(matrix);

            string[] inputCommand = Console.ReadLine()
                .Split()
                .ToArray();

            while (inputCommand[0] != "Stop")
            {
                string command = inputCommand[0];
                int givenRow = int.Parse(inputCommand[1]);
                int givenCol = int.Parse(inputCommand[2]);
                IsInside(matrix, givenRow, givenCol);



                if (command == "Collect")
                {
                    if (IsInside(matrix, givenRow, givenCol) && matrix[givenRow, givenCol] == 'B')
                    {
                        blackTruffleCount++;
                        matrix[givenRow, givenCol] = '-';
                    }
                    else if (IsInside(matrix, givenRow, givenCol) && matrix[givenRow, givenCol] == 'S')
                    {
                        summerTruffleCount++;
                        matrix[givenRow, givenCol] = '-';
                    }
                    else if (IsInside(matrix, givenRow, givenCol) && matrix[givenRow, givenCol] == 'W')
                    {
                        whiteTruffleCount++;
                        matrix[givenRow, givenCol] = '-';
                    }
                    else if (IsInside(matrix, givenRow, givenCol) && matrix[givenRow, givenCol] == '-')
                    {
                        inputCommand = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                }
                else if (command == "Wild_Boar")
                {
                    if (IsTruffle(matrix, givenRow, givenCol))
                    {
                        wildBoarEatsCount++;
                        matrix[givenRow, givenCol] = '-';
                    }
                    if (inputCommand[3] == "up")
                    {
                        //if (IsInside(matrix, givenRow - 2, givenCol))
                        //{
                        //    wildBoarEatsCount++;
                        //    matrix[givenRow - 2, givenCol] = '-';
                        //}

                        for (int row = givenRow; row >= 0; row-=2)
                        {
                            if (IsTruffle(matrix, row, givenCol))
                            {
                                wildBoarEatsCount++;
                            }
                            matrix[row, givenCol] = '-';
                        }
                       
                    }
                    if (inputCommand[3] == "down")
                    {
                        //if (IsInside(matrix, givenRow + 2, givenCol))
                        //{
                        //    wildBoarEatsCount++;
                        //    matrix[givenRow + 2, givenCol] = '-';
                        //}
                        for (int row = givenRow; row < matrix.GetLength(0); row += 2)
                        {
                            if (IsTruffle(matrix, row, givenCol))
                            {
                                wildBoarEatsCount++;
                            }
                            matrix[row, givenCol] = '-';
                        }

                    }
                    if (inputCommand[3] == "right")
                    {
                        //if (IsInside(matrix, givenRow, givenCol + 2))
                        //{
                        //    wildBoarEatsCount++;
                        //    matrix[givenRow, givenCol + 2] = '-';
                        //}

                        for (int col = givenCol; col < matrix.GetLength(1); col += 2)
                        {
                            if (IsTruffle(matrix, givenRow, col))
                            {
                                wildBoarEatsCount++;
                            }
                           
                            matrix[givenRow, col] = '-';
                        }
                    }
                    
                    if (inputCommand[3] == "left")
                    {
                        //if (IsInside(matrix, givenRow, givenCol - 2))
                        //{
                        //    wildBoarEatsCount++;
                        //    matrix[givenRow, givenCol - 2] = '-';
                        //}
                        //
                        for (int col = givenCol; col >= 0; col -= 2)
                        {
                            if (IsTruffle(matrix, givenRow, col))
                            {
                                wildBoarEatsCount++;
                            }

                            matrix[givenRow, col] = '-';
                        }

                    }
                }


                inputCommand = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Peter manages to harvest {blackTruffleCount} black, {summerTruffleCount} summer, and {whiteTruffleCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {wildBoarEatsCount} truffles.");
            Printmatrix(matrix);
        }

        private static bool IsTruffle(char[,] matrix, int givenRow, int givenCol)
        {
            return matrix[givenRow, givenCol] == 'B' || matrix[givenRow, givenCol] == 'S' || matrix[givenRow, givenCol] == 'W';
        }

        private static void Initialize(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] secondInput = Console.ReadLine()
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .Select(char.Parse)
                      .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = secondInput[cols];
                }
            }
        }

        private static bool IsInside(char[,] matrix, int givenRow, int givenCol)
        {
            return givenRow >= 0 && givenRow < matrix.GetLength(0) &&
                   givenCol >= 0 && givenCol < matrix.GetLength(1);
        }
        private static void Printmatrix(char[,] matrix)
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
