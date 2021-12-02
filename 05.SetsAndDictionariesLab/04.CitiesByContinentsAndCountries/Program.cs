using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentsAndCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var info = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!info.ContainsKey(continent))
                {
                    info.Add(continent, new Dictionary<string, List<string>>());
                    
                }

                if (!info[continent].ContainsKey(country))
                {
                    info[continent].Add(country, new List<string>());
                    info[continent][country].Add(city);
                }
                else
                {
                    info[continent][country].Add(city);
                }
            }

            //Europe:
            //France->Paris
            //Germany->Hamburg, Danzig
            //Poland->Gdansk

            foreach (var item in info)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var values in item.Value)
                {
                    Console.WriteLine($"  {values.Key} -> {string.Join(", ",values.Value)}");
                }
            }

        }
    }
}
