using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BOmbs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bombEffect = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            List<int> bombCasing = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            int daturaBombsSum = 40;
            int cherryBombsSum = 60;
            int smokeDecoyBombsSum = 120;

            int daturaBombCount = 0;
            int cherryBombsCount = 0;
            int smokeDecoyBombsCount = 0;
            bool ifRemoved = false;

            for (int i = 0; i <= bombEffect.Count; i++)
            {
               if (bombEffect.Count == 0 || bombCasing.Count == 0)
               {
                   Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                   if (bombEffect.Count == 0)
                   {
                       Console.WriteLine("Bomb Effects: empty");
                   }
                   else
                   {
                       Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
                   }
                   if (bombCasing.Count == 0)
                   {
                       Console.WriteLine("Bomb Casings: empty");
                   }
                   else
                   {
                       Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
                   }

                   Console.WriteLine($"Cherry Bombs: {cherryBombsCount}");
                   Console.WriteLine($"Datura Bombs: {daturaBombCount}");
                   Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombsCount}");
                   return;
               }
               if (cherryBombsCount >=3 && daturaBombCount>=3 && smokeDecoyBombsCount>=3)
               {
                   Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                   Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
                   Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");

                   Console.WriteLine($"Cherry Bombs: {cherryBombsCount}");
                   Console.WriteLine($"Datura Bombs: {daturaBombCount}");
                   Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombsCount}");
                   return;
               }
                if (ifRemoved && i!=0)
                {
                    i--;
                }

                for (int j = bombCasing.Count - 1; j >= 0; j--)
                {
                    
                    if (bombEffect[i] + bombCasing[j] == daturaBombsSum)
                    {
                        daturaBombCount++;
                        bombEffect.RemoveAt(i);
                        bombCasing.RemoveAt(j);
                        ifRemoved = true;
                        break;
                    }
                   
                    else if (bombEffect[i] + bombCasing[j] == cherryBombsSum)
                    {
                        cherryBombsCount++;
                        bombEffect.RemoveAt(i);
                        bombCasing.RemoveAt(j);
                        ifRemoved = true;
                        break;
                    }
                    else if (bombEffect[i] + bombCasing[j] == smokeDecoyBombsSum)
                    {
                        smokeDecoyBombsCount++;
                        bombEffect.RemoveAt(i);
                        bombCasing.RemoveAt(j);
                        ifRemoved = true;
                        break;
                    }

                    else if (bombEffect[i] + bombCasing[j] != daturaBombsSum &&
                            bombEffect[i] + bombCasing[j] != cherryBombsCount &&
                            bombEffect[i] + bombCasing[j] != smokeDecoyBombsCount)
                    {

                        bombCasing[j] -= 5;
                        j++;
                    }

                }
            }

            if (bombEffect.Count == 0 || bombCasing.Count == 0)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                if (bombEffect.Count == 0)
                {
                    Console.WriteLine("Bomb Effects: empty");
                }
                else
                {
                    Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
                }
                if (bombCasing.Count == 0)
                {
                    Console.WriteLine("Bomb Casings: empty");
                }
                else
                {
                    Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
                }

                Console.WriteLine($"Cherry Bombs: {cherryBombsCount}");
                Console.WriteLine($"Datura Bombs: {daturaBombCount}");
                Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombsCount}");
                //return;
            }
            if (cherryBombsCount >= 3 && daturaBombCount >= 3 && smokeDecoyBombsCount >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");

                Console.WriteLine($"Cherry Bombs: {cherryBombsCount}");
                Console.WriteLine($"Datura Bombs: {daturaBombCount}");
                Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombsCount}");
                //return;
            }
        }
    }
}
