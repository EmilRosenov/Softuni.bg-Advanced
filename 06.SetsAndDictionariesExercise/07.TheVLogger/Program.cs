using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var vLogger = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (input!= "Statistics")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[1]=="joined")
                {
                    string user = command[0];
                    if (!vLogger.ContainsKey(user))
                    {
                        vLogger.Add(user, new Dictionary<string, SortedSet<string>>());
                        vLogger[user].Add("followed", new SortedSet<string>());
                        vLogger[user].Add("follow", new SortedSet<string>());
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                else if (command[1]=="followed")
                {
                    string mainUser = command[2];
                    string follower = command[0];

                    if (mainUser==follower)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    if (!vLogger.ContainsKey(mainUser) || !vLogger.ContainsKey(follower))
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    vLogger[mainUser]["followed"].Add(follower);
                    vLogger[follower]["follow"].Add(mainUser);
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");

            var sorted = vLogger.OrderByDescending(x => x.Value["followed"].Count)
                .ThenBy(x => x.Value["follow"].Count)
                .ToDictionary(k => k.Key, v => v.Value);

            int counter = 1;
            foreach (var vlogger in sorted)
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followed"].Count} followers, {vlogger.Value["follow"].Count} following ");

                if (counter==1)
                {
                    foreach (var followers in vlogger.Value["followed"])
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }

                counter++;
            }
        }
    }
}
