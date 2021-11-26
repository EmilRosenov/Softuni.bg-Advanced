using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;


            string[] direction = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> commandsQueue = new Queue<string>();

            foreach (string command in direction)
            {
                commandsQueue.Enqueue(command);
            }
            char[,] field = new char[rows, cols];
            FieldCreation(field);

            int numberCoals = 0;
            foreach (char coals in field)
            {
                if (coals == 'c')
                {
                    numberCoals++;
                }
            }

           
            int currentRow = 0;
            int currentCol = 0;


            for (int row = 0; row < rows; row++)
            {
                currentRow = row;
                for (int col = 0; col < cols; col++)
                {
                    currentCol = col;

                    if (field[currentRow, currentCol] == 's')
                    {
                        IsInside(field, row, col);
                        while (commandsQueue.Count > 0)
                        {
                            
                            switch (commandsQueue.Dequeue())
                            {
                                case "up":
                                    if (IsInside(field, currentRow - 1, currentCol))
                                    {
                                       
                                        if (field[currentRow - 1, currentCol] == 'e')
                                        {
                                            currentRow = currentRow - 1;
                                            currentCol = currentCol;
                                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                        else if (field[currentRow - 1, currentCol] == 'c'
                                            || field[currentRow - 1, currentCol] == 's')
                                        {
                                            if (field[currentRow-1, currentCol] == 'c')
                                            {
                                                numberCoals--;
                                            }
                                            
                                            field[currentRow - 1, col] = '*';
                                            currentRow = currentRow - 1;
                                            currentCol = col;
                                        }
                                        else
                                        {
                                            currentRow = currentRow - 1;
                                            currentCol = currentCol;
                                        }
                                        
                                        if (numberCoals == 0)
                                        {
                                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;

                                case "down":
                                    if (IsInside(field, currentRow + 1, currentCol))
                                    {
                                        
                                        if (field[currentRow + 1, currentCol] == 'e')
                                        {
                                            currentRow = currentRow + 1;
                                            currentCol = currentCol;
                                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                        else if (field[currentRow + 1, currentCol] == 'c'
                                            || field[currentRow + 1, currentCol] == 's')
                                        {
                                            if (field[currentRow + 1, currentCol] == 'c')
                                            {
                                                numberCoals--;
                                            }
                                            
                                            field[currentRow + 1, currentCol] = '*';
                                            currentRow = currentRow + 1;
                                            currentCol = currentCol;
                                        }
                                        else
                                        {
                                            currentRow = currentRow + 1;
                                            currentCol = currentCol;
                                        }

                                        if (numberCoals == 0)
                                        {
                                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;

                                case "left":
                                    if (IsInside(field, currentRow, currentCol - 1))
                                    {
                                       
                                        if (field[currentRow, currentCol - 1] == 'e')
                                        {
                                            currentRow = currentRow;
                                            currentCol = currentCol - 1;
                                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                        else if (field[currentRow, currentCol - 1] == 'c'
                                            || field[currentRow, currentCol - 1] == 's')
                                        {
                                            if (field[currentRow, currentCol - 1] == 'c')
                                            {
                                                numberCoals--;
                                            }
                                            
                                            field[currentRow, currentCol - 1] = '*';
                                            currentRow = currentRow;
                                            currentCol = currentCol - 1;
                                        }
                                        else
                                        {
                                            currentRow = currentRow;
                                            currentCol = currentCol - 1;
                                        }

                                        if (numberCoals == 0)
                                        {
                                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;

                                case "right":
                                    if (IsInside(field, currentRow, currentCol + 1))
                                    {
                                        if (field[currentRow, currentCol+1] == 'e')
                                        {
                                            currentRow = currentRow;
                                            currentCol = currentCol + 1;
                                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                        else if (field[currentRow, currentCol + 1] == 'c' 
                                            || field[currentRow, currentCol + 1] == 's')
                                        {
                                            if (field[currentRow, currentCol + 1] == 'c')
                                            {
                                                numberCoals--;
                                            }
                                            
                                            field[currentRow, currentCol + 1] = '*';
                                            currentRow = currentRow;
                                            currentCol = currentCol + 1;
                                        }
                                        else
                                        {
                                            currentRow = currentRow;
                                            currentCol = currentCol + 1;
                                        }
                                        if (numberCoals == 0)
                                        {
                                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;

                            }
                            if (commandsQueue.Count == 0)
                            {
                                Console.WriteLine($"{numberCoals} coals left. ({currentRow}, {currentCol})");
                                Environment.Exit(0);
                            }
                        }
                    }

                }
            }
            
        }


        private static bool IsInside(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0)
                && col >= 0 && col < field.GetLength(1);
        }

        private static void FieldCreation(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = char.Parse(input[col]);
                }
            }
        }
    }
}
