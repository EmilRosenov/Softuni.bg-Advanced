using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleComming = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            while (true)
            {
                string[] commandInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commandInfo[0];
                if (command=="Party!")
                {
                    break;
                }

                string condition = commandInfo[1];
                string parameter = commandInfo[2];

                Predicate<string> predicate = GetPredicate(condition, parameter);

                if (command=="Remove")
                {
                    peopleComming.RemoveAll(predicate);

                }
                else if (command=="Double")
                {
                    List<string> doubledNames = peopleComming.FindAll(predicate);

                    if (doubledNames.Any())
                    {
                        int index = peopleComming.FindIndex(predicate);
                        peopleComming.InsertRange(index, doubledNames);
                    }
                   
                }
                
            }
            if (peopleComming.Any())
            {
                Console.WriteLine($"{string.Join(", ", peopleComming)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string condition, string parameter)
        {
            if (condition == "StartsWith")
            {
                return x => x.StartsWith(parameter);
            }
            if(condition == "EndsWith")
            {
                return x => x.EndsWith(parameter);
            }

            int lenght = int.Parse(parameter);
            return x => x.Length == lenght;
        }
    }
}
