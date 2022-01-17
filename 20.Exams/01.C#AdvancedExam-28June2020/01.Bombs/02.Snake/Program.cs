using System;
using System.Linq;

namespace _02.Snake
{
    public class Program
    {
        public int foodQuantity;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int snakeRow = -1;
            int snakeCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row,col]=='S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }

            //PrintMatrix(matrix);
            IsInside(matrix, n, n);
           
            
            int foodQuantity = 0;
            
            while (true)
            {
                string command = Console.ReadLine();

                Move(command,matrix,snakeRow,snakeCol);

                if (IsInside(matrix, snakeRow, snakeCol) == false || foodQuantity >= 10)
                {
                    break;
                }

                
            }


            if (!IsInside(matrix, n, n))
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {foodQuantity}");
                PrintMatrix(matrix);
            }
            else if (foodQuantity >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
                Console.WriteLine($"Food eaten: {foodQuantity}");
                PrintMatrix(matrix);
            }

        }

        public static void Move(string command,char[,]matrix, int snakeRow, int snakeCol)
        {
            
            if (command== "left")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (IsFood(matrix, snakeRow, snakeCol))
                {

                    matrix[snakeRow, snakeCol - 1] = 'S';
                    snakeCol -= 1;
                }

            }
            else if (command == "right")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (matrix[snakeRow, snakeCol + 1] == '*')
                {
                    foodQuantity++;
                    matrix[snakeRow, snakeCol + 1] = 'S';
                }
               
            }
            else if (command == "up")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (matrix[snakeRow-1, snakeCol] == '*')
                {
                    foodQuantity++;
                    matrix[snakeRow-1, snakeCol] = 'S';
                }
               
            }
            else if (command == "down")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (matrix[snakeRow +1, snakeCol] == '*')
                {
                    foodQuantity++;
                    matrix[snakeRow +1, snakeCol] = 'S';
                }
            }
        }

        private static bool IsFood(char[,] matrix, int snakeRow, int snakeCol)
        {
            return matrix[snakeRow, snakeCol - 1] == '*';
        }

        public static bool IsInside(char[,]matrix,int row, int col)
        {
            if (row < matrix.GetLength(0) && row >= 0 
                && col <matrix.GetLength(1) && col >=0)
            {
                return true;
            }
            return false;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
        
    }
}
