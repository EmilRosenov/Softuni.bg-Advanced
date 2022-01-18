using System;
using System.Linq;

namespace _02.Snake
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int snakeRow = -1;
            int snakeCol = -1;
            int firstBurrowRow = -1;
            int firstBurrowCol = -1;
            int secondBurrowRow = -1;
            int secondBurrowCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row,col] =='S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    if (matrix[row, col] == 'B')
                    {
                        if (firstBurrowRow == -1)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                        }
                        else
                        {
                            secondBurrowRow = row;
                            secondBurrowCol = col;
                        }
                    }
                }
            }
            
            
            int foodQuantity = 0;
            
            while (true)
            {
                if (foodQuantity >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {foodQuantity}");
                    PrintMatrix(matrix);
                    return;
                }
               

                string command = Console.ReadLine();

               
                
                if (command == "up") 
                {
                    if (IsInside(matrix, snakeRow - 1, snakeCol))
                    {
                        if (IsFood(matrix, snakeRow - 1, snakeCol))
                        {
                            foodQuantity++;
                        }
                        matrix[snakeRow, snakeCol] = '.';
                        //matrix[snakeRow - 1, snakeCol] = 'S';
                        snakeRow = snakeRow - 1;
                    }
                    else
                    {
                        break;
                    }

                }
                if (command == "down") 
                {
                    if (IsInside(matrix, snakeRow + 1, snakeCol))
                    {
                        if (IsFood(matrix, snakeRow + 1, snakeCol))
                        {
                            foodQuantity++;
                        }
                        matrix[snakeRow, snakeCol] = '.';
                        //matrix[snakeRow + 1, snakeCol] = 'S';
                        snakeRow = snakeRow + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (command == "left") 
                {
                    if (IsInside(matrix, snakeRow, snakeCol - 1))
                    {
                        if (IsFood(matrix, snakeRow, snakeCol - 1))
                        {
                            foodQuantity++;
                        }
                        matrix[snakeRow, snakeCol] = '.';
                        //matrix[snakeRow, snakeCol-1] = 'S';
                        snakeCol = snakeCol - 1;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                if (command == "right")
                {
                    if (IsInside(matrix, snakeRow, snakeCol + 1))
                    {
                        if (IsFood(matrix, snakeRow, snakeCol + 1))
                        {
                            foodQuantity++;
                        }
                        matrix[snakeRow, snakeCol] = '.';
                        //matrix[snakeRow, snakeCol+1] = 'S';
                        snakeCol = snakeCol + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    if (firstBurrowRow==snakeRow && firstBurrowCol == snakeCol)
                    {
                        matrix[firstBurrowRow, firstBurrowCol] = '.';
                        snakeRow = secondBurrowRow;
                        snakeCol = secondBurrowCol;
                    }
                    else
                    {
                        matrix[secondBurrowRow, secondBurrowCol] = '.';
                        snakeRow = firstBurrowRow;
                        snakeCol = firstBurrowCol;
                    }
                }

                
                matrix[snakeRow, snakeCol] = 'S';
                //PrintMatrix(matrix);
            }
           
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {foodQuantity}");
                matrix[snakeRow, snakeCol] = '.';
                PrintMatrix(matrix);
     
        }

        private static bool IsFood(char[,] matrix, int snakeRow, int snakeCol)
        {
            return matrix[snakeRow, snakeCol] == '*';
        }

        private static bool IsInside(char[,] matrix, int snakeRow, int snakeCol)
        {
            if (snakeRow < 0 || snakeCol < 0
                || snakeRow >= matrix.GetLength(0)
                || snakeCol >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                 Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
