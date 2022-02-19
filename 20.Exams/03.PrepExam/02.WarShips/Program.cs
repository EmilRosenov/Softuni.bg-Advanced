using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PrepExam21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            int[] coordinatesInput = Console.ReadLine()
                                    .Split(new char[] { ' ', ',' })
                                    .Select(int.Parse)
                                    .ToArray();


            int firstPlayer = 0;
            int secondPLayer = 0;
            int totalCount = 0;
            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = char.Parse(input[col]);
                    if (field[row, col] == '<')
                    {
                        firstPlayer++;
                    }
                    if (field[row, col] == '>')
                    {
                        secondPLayer++;
                    }
                }
            }

            for (int i = 0; i < coordinatesInput.Length; i+=2)
            {
                int attackRow = coordinatesInput[i];
                int attackCol = coordinatesInput[i+1];

                if (!Isinrange(field,attackRow, attackCol))
                {
                    continue;
                }

                if (field[attackRow,attackCol]=='>')
                {
                    secondPLayer--;
                    field[attackRow, attackCol] = 'X';
                    totalCount++;
                }
                else if (field[attackRow, attackCol] == '<')
                {
                    firstPlayer--;
                    field[attackRow, attackCol] = 'X';
                    totalCount++;
                }
                else if (field[attackRow, attackCol] == '#')
                {
                    //up
                    if (Isinrange(field,attackRow-1,attackCol))
                    {
                        if (field[attackRow - 1, attackCol] == '<')
                        {
                            firstPlayer--;
                        }
                        else if (field[attackRow - 1, attackCol] == '>')
                        {
                            secondPLayer--;
                        }
                        field[attackRow - 1, attackCol] = 'X';
                        totalCount++;
                    }
                    //down
                    if (Isinrange(field, attackRow +1, attackCol))
                    {
                        if (field[attackRow +1, attackCol] == '<')
                        {
                            firstPlayer--;
                        }
                        else if (field[attackRow + 1, attackCol] == '>')
                        {
                            secondPLayer--;
                        }
                        field[attackRow + 1, attackCol] = 'X';
                        totalCount++;
                    }
                    //left
                    if (Isinrange(field,attackRow,attackCol-1))
                    {
                        if (field[attackRow,attackCol-1]=='<')
                        {
                            firstPlayer--;
                        }
                        else if (field[attackRow, attackCol - 1] == '>')
                        {
                            secondPLayer--;
                        }
                        field[attackRow, attackCol - 1] = 'X';
                        totalCount++;
                    }
                    //right
                    if (Isinrange(field,attackRow,attackCol+1))
                    {
                        if (field[attackRow, attackCol + 1]=='>')
                        {
                            secondPLayer--;
                        }
                        if (field[attackRow, attackCol + 1] == '<')
                        {
                            firstPlayer--;
                        }
                        field[attackRow, attackCol + 1] = 'X';
                        totalCount++;
                    }
                    //upright
                    if (Isinrange(field,attackRow-1,attackCol+1))
                    {
                        if (field[attackRow-1, attackCol + 1] == '>')
                        {
                            secondPLayer--;
                        }
                        if (field[attackRow-1, attackCol + 1] == '<')
                        {
                            firstPlayer--;
                        }
                        field[attackRow-1, attackCol + 1] = 'X';
                        totalCount++;
                    }
                    //downRight
                    if (Isinrange(field, attackRow + 1, attackCol + 1))
                    {
                        if (field[attackRow + 1, attackCol + 1] == '>')
                        {
                            secondPLayer--;
                        }
                        if (field[attackRow + 1, attackCol + 1] == '<')
                        {
                            firstPlayer--;
                        }
                        field[attackRow + 1, attackCol + 1] = 'X';
                        totalCount++;
                    }
                    //upleft
                    if (Isinrange(field,attackRow-1,attackCol-1))
                    {

                        if (field[attackRow - 1, attackCol - 1] == '>')
                        {
                            secondPLayer--;
                        }
                        if (field[attackRow - 1, attackCol - 1] == '<')
                        {
                            firstPlayer--;
                        }
                        field[attackRow - 1, attackCol - 1] = 'X';
                        totalCount++;
                    }
                    //downLeft
                    if (Isinrange(field, attackRow + 1, attackCol - 1))
                    {
                        if (field[attackRow + 1, attackCol - 1]=='>')
                        {
                            secondPLayer--;
                        }
                        if (field[attackRow + 1, attackCol - 1] == '<')
                        {
                            firstPlayer--;
                        }
                        field[attackRow + 1, attackCol - 1] = 'X';
                        totalCount++;
                    }
                }

                if (secondPLayer==0 || firstPlayer==0)
                {
                    break;
                }
            }

            if (secondPLayer==0)
            {
                Console.WriteLine($"Player One has won the game! {totalCount} ships have been sunk in the battle.");
            }
            else if (firstPlayer==0)
            {
                Console.WriteLine($"Player Two has won the game! {totalCount} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayer} ships left. Player Two has {secondPLayer} ships left.");
            }

            
        }

        public static bool Isinrange(char[,] field, int attackRow, int attackCol)
        {
            if (attackRow >= 0 && attackRow < field.GetLength(0) &&
            attackCol >= 0 && attackCol < field.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
