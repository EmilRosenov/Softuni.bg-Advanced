using System;
using System.Collections.Generic;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chessboard = new char[n, n];
            FillChessboard(chessboard);

            //char current = chessboard[row, col];
            //  - 2 row, -1 col !
            //  - 2 row, +1col !
            //  - 1 row, -2 col !
            //  - 1 row, +2 col !
            //  + 1 row,-2 col !
            //  + 1 row,+2col  !
            //  + 2 row, -1 col
            //  + 2 row, +1col

            int numberAttacks = 0;
            int maxAttacks = 0;
            int bestRow = int.MinValue;
            int bestCol = int.MinValue;
            
            int knightsCounter = 0;

            while (true)
            {
                maxAttacks = 0;

                for (int row = 0; row < chessboard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessboard.GetLength(1); col++)
                    {
                        char current = chessboard[row, col];
                        numberAttacks = 0;
                        //IsInside(chessboard, row, col)
                        if (current == 'K')
                        {
                            if (IsInside(chessboard, row - 2, col - 1))
                            {
                                if (chessboard[row - 2, col - 1] == 'K')
                                {
                                    numberAttacks++;
                                }
                            }
                            if (IsInside(chessboard, row - 2, col + 1))
                            {
                                if (chessboard[row - 2, col + 1] == 'K')
                                {
                                    numberAttacks++;
                                }
                            }
                            if (IsInside(chessboard, row - 1, col - 2))
                            {
                                if (chessboard[row - 1, col - 2] == 'K')
                                {
                                    numberAttacks++; 
                                }

                            }
                            if (IsInside(chessboard, row - 1, col + 2))
                            {
                                if (chessboard[row - 1, col + 2] == 'K')
                                {
                                    numberAttacks++;
                                }

                            }
                            if (IsInside(chessboard, row + 1, col - 2))
                            {
                                if (chessboard[row + 1, col - 2] == 'K')
                                {
                                    numberAttacks++;
                                }

                            }
                            if (IsInside(chessboard, row + 1, col + 2))
                            {

                                if (chessboard[row + 1, col + 2] == 'K')
                                {
                                    numberAttacks++;
                                }
                            }
                            if (IsInside(chessboard, row + 2, col - 1))
                            {
                                if (chessboard[row + 2, col - 1] == 'K')
                                {
                                    numberAttacks++;
                                }
                            }
                            if (IsInside(chessboard, row + 2, col + 1))
                            {
                                if (chessboard[row + 2, col + 1] == 'K')
                                {
                                    numberAttacks++;
                                }
                            }
                        }
                        if (numberAttacks > maxAttacks)
                        {
                            maxAttacks = numberAttacks;
                            bestRow = row;
                            bestCol = col;
                           
                        }
                    }
                    
                }

                if (maxAttacks > 0)
                {
                    chessboard[bestRow, bestCol] = '0';
                    knightsCounter++;
                }
                else
                {
                    Console.WriteLine(knightsCounter);
                    break;
                }
            }

        }

        private static bool IsInside(char[,] chessboard, int row, int col)
        {
            return row >= 0 && row < chessboard.GetLength(0)
                && col >= 0 && col < chessboard.GetLength(1);
        }

        private static void PrintChessboard(char[,] chessboard)
        {
            for (int rows = 0; rows < chessboard.GetLength(0); rows++)
            {
                for (int cols = 0; cols < chessboard.GetLength(1); cols++)
                {
                    Console.Write(chessboard[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        public static void FillChessboard(char[,] chessboard)
        {
            for (int rows = 0; rows < chessboard.GetLength(0); rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < chessboard.GetLength(1); cols++)
                {
                    chessboard[rows, cols] = input[cols];
                }
            }
        }
    }
}
