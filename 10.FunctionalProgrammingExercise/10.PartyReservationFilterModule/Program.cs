using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var dictionary = new Dictionary<string, Predicate<string>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = input[0];
               


                if (command== "Print")
                {
                    foreach (var item in dictionary)
                    {
                        people.RemoveAll(item.Value);
                    }
                    Console.WriteLine($"{string.Join(" ",people)}");
                    return;
                }

                string filterType = input[1];
                string parameter = input[2];

                string key = filterType + "_" + parameter;

                if (command == "Add filter")
                {
                    
                    Predicate<string> predicate = GetPredicate(filterType, parameter);
                    dictionary.Add(key, predicate);
                    
                }
                else
                {
                    dictionary.Remove(key);
                }
            }
        }

        private static Predicate<string> GetPredicate(string filterType, string parameter)
        {
            if (filterType == "Starts with")
            {
                return x => x.StartsWith(parameter);
            }
            if (filterType == "Ends with")
            {
                return x => x.EndsWith(parameter);
            }
            if (filterType == "Contains")
            {
                return x => x.Contains(parameter);
            }
              return x => x.Length == int.Parse(parameter);
            
                
        }
    }
}
