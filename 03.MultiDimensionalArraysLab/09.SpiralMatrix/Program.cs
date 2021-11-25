using System;

namespace _09.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int rows = 0;
            int cols = 0;
            string direction = "right";
            
            for (int i = 0; i < n*n; i++)
            {
                matrix[rows, cols] = i+1;

                if (direction=="right")
                {
                    cols++;
                    
                    if (cols == n || matrix[rows, cols] != 0)
                    {
                        cols -= 1;
                        direction = "down";
                    }
                }
                if (direction=="down")
                {
                    rows++;
                    if (rows==n || matrix[rows, cols] != 0)
                    {
                        rows -= 1;
                        direction = "left";
                    }
                }
                if (direction=="left")
                {
                    cols--;
                    if (cols==-1 || matrix[rows, cols] != 0)
                    {
                        cols+=1;
                        direction = "up";
                    }
                }
                if (direction=="up")
                {
                    rows-=1;
                    
                    if (rows ==-1 || matrix[rows, cols] != 0)
                    {
                        rows += 1;
                        direction = "right";
                        cols++;
                    }
                   
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 10)
                    {
                        Console.Write(" " + matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
