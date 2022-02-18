using System;
using System.Linq;

namespace _02.BattleOfFiveArmies
{
    class Program
    {
        static void Main()
        {
            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            //Input
            for (int row = 0; row < rows; row++)
            {
                var chars = Console.ReadLine().ToCharArray();
                matrix[row] = chars;
            }


            int heroRow = 0;
            int heroCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'A')
                    {
                        heroRow = i;
                        heroCol = j;
                    }
                }
            }
           
            //Moves
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string movigDirection = input[0]; 
                int orcRow = int.Parse(input[1]); 
                int orcCol = int.Parse(input[2]);

                matrix[orcRow][orcCol] = 'O';
                armor--;
                matrix[heroRow][heroCol] = '-';
                if (movigDirection=="up" && heroRow-1>=0)
                {
                    heroRow--;
                }
                else if (movigDirection == "right" && heroCol+1 < matrix[heroCol].Length)
                {
                    heroCol++;
                }
                else if (movigDirection == "left" && heroCol-1>=0)
                {
                    heroCol--;
                }
                else if (movigDirection == "down" && heroRow+1 < rows)
                {
                    heroRow++;
                }

                if (matrix[heroRow][heroCol]=='O')
                {
                    armor -= 2;
                }
                if (armor <= 0)
                {
                    Console.WriteLine($"The army was defeated at {heroRow};{heroCol}.");
                    matrix[heroRow][heroCol] = 'X';
                    break;
                }
                if (matrix[heroRow][heroCol]=='M')
                {
                    matrix[heroRow][heroCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }
                matrix[heroRow][heroCol] = 'A';
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
