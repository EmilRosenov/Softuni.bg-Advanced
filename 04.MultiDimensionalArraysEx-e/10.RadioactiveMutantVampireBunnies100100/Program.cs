using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunniesTeacher
{
    class Program
    {
        static char[,] field;
        static  int playerRow;
        static int playerCol;
        static bool isDead;

        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                 .ToArray();

            int totalRows = size[0];
            int totalCols = size[1];

            field = new char[totalRows, totalCols];

            PopulateField();

            char[] directions = Console.ReadLine().ToCharArray();

            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case 'U':
                        Move(-1, 0);

                        break;

                    case 'D':
                        Move(+1, 0);

                        break;
                    case 'L':
                        Move(0, -1);

                        break;

                    case 'R':
                        Move(0, +1);

                        break;
                }

                Spread();

                if (isDead)
                {
                    Print();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");

                    Environment.Exit(0);
                }
            }
            
        }

        private static void PopulateField()
        {
            for (int rows = 0; rows < field.GetLength(0); rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int cols = 0; cols < field.GetLength(1 ); cols++)
                {
                    field[rows, cols] = input[cols];

                    if (field[rows,cols] == 'P')
                    {
                        playerRow = rows;
                        playerCol = cols;

                    }

                }
            }
        }

        private static void Spread()
        {
            List<int> bunniesPositions = new List<int>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]=='B')
                    {
                        bunniesPositions.Add(row);
                        bunniesPositions.Add(col);
                    }
                }
            }

            int bunnyRow = 0;
            int bunnyCol = 0;


            for (int i = 0; i < bunniesPositions.Count; i+=2)
            {
                bunnyRow = bunniesPositions[i];
                bunnyCol = bunniesPositions[i+1];


                if (IsInside(bunnyRow, bunnyCol+1))
                {
                    if (field[bunnyRow, bunnyCol+1] == 'P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow, bunnyCol + 1] = 'B';
                }

                if (IsInside(bunnyRow, bunnyCol - 1))
                {
                    if (field[bunnyRow, bunnyCol - 1] == 'P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow, bunnyCol - 1] = 'B';
                }

                if (IsInside(bunnyRow-1, bunnyCol))
                {
                    if (field[bunnyRow-1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow-1, bunnyCol] = 'B';
                }

                if (IsInside(bunnyRow + 1, bunnyCol))
                {
                    if (field[bunnyRow + 1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow + 1, bunnyCol] = 'B';
                }
            }
        }

        private static bool IsInside(int playerRow, int playerCol)
        {
            return playerRow >= 0 && playerRow < field.GetLength(0)
                && playerCol >= 0 && playerCol < field.GetLength(1);
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(playerRow+row,playerCol+col))
            {
                field[playerRow, playerCol] = '.';
                Spread();
                Print();
                Console.WriteLine($"won: {playerRow} {playerCol}");
                //TODO SPread();
                Environment.Exit(0); 

            }

           
            if (field[playerRow + row, playerCol + col] =='B')
            {
                Spread();
                Print();
                Console.WriteLine($"dead: {playerRow + row} {playerCol + col}");
                //TODO SPread();
                Environment.Exit(0);
            }

            field[playerRow, playerCol] = '.';
            playerRow += row;
            playerCol += col;
            field[playerRow, playerCol] = 'P';
        }

        private static void Print()
        {
            for (int row = 0; row <field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
