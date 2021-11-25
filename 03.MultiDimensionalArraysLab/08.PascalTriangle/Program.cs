using System;

namespace _08.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];
            int col = 1;
            for (int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[col];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;


                if (row>1)
                {
                    for (int cols = 1; cols < pascal[row].Length-1; cols++)
                    {
                        long[] prevRow = pascal[row - 1];
                        long firstNum = prevRow[cols];
                        long secondNum = prevRow[cols-1];
                        pascal[row][cols] = firstNum + secondNum;
                    }
                }
                col++;
            }

            for (int row = 0; row < pascal.Length; row++)
            {
                for (int column = 0; column < pascal[row].Length; column++)
                {
                    Console.Write(pascal[row][column] +" ");
                }
                Console.WriteLine();
            }

        }
    }
}
