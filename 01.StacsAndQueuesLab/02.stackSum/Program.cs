using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.stackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            Stack<int> stckNumbers = new Stack<int>(inputNumbers);

            string[] commandInput = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (commandInput[0].ToUpper()!="END")
            {
                string command = commandInput[0];
                if (command.ToUpper()=="ADD")
                {
                    int first = int.Parse(commandInput[1]);
                    int second = int.Parse(commandInput[2]);

                    stckNumbers.Push(first);
                    stckNumbers.Push(second);
                }
                else if (command.ToUpper() == "REMOVE")
                {
                    int countElementsToRemove = int.Parse(commandInput[1]);
                    if (countElementsToRemove > stckNumbers.Count)
                    {
                        commandInput = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else
                    {
                        while (countElementsToRemove > 0)
                        {
                            stckNumbers.Pop();
                            countElementsToRemove--;
                        }
                       
                    }

                }
                commandInput = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Sum: {stckNumbers.Sum()}");
        }
    }
}
