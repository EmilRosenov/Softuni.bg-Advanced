using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();
            var studentData = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of contests")
                {
                    break;
                }
                string contest = input[0];
                string password = input[1];

                if (!data.ContainsKey(contest))
                {
                    data.Add(contest, password);
                }
            }

            string[] inputTwo = Console.ReadLine()
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

            while (inputTwo[0] != "end of submissions")
            {
                string contest = inputTwo[0];
                string pass = inputTwo[1];
                string studentName = inputTwo[2];
                int points = int.Parse(inputTwo[3]);

                if (data.ContainsKey(contest) && data.ContainsValue(pass))
                {
                    if (!studentData.ContainsKey(studentName))
                    {
                        studentData.Add(studentName, new Dictionary<string, int>());

                        if (!studentData[studentName].ContainsKey(contest))
                        {
                            studentData[studentName].Add(contest, points);
                        }
                        else
                        {
                            if (points > studentData[studentName][contest])
                            {
                                studentData[studentName][contest] = points;
                            }
                        }
                    }
                    else
                    {
                        if (!studentData[studentName].ContainsKey(contest))
                        {
                            studentData[studentName].Add(contest, points);
                        }
                        else
                        {
                            if (points > studentData[studentName][contest])
                            {
                                studentData[studentName][contest] = points;
                            }
                        }
                    }

                }

                inputTwo = Console.ReadLine()
                .Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            var sorted = studentData.OrderBy(x => x.Key).ThenByDescending(v => v.Value).ToDictionary(a => a.Key, b => b.Value);
            var topCandidate = studentData.OrderByDescending(x => x.Value.Sum(x => x.Value)).FirstOrDefault();

            Console.WriteLine($"Best candidate is {topCandidate.Key} with total {topCandidate.Value.Sum(x=>x.Value)} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in sorted)
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}

