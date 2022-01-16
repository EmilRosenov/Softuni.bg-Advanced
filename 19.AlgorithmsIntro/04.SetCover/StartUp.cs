using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine()
                                 .Split(", ")
                                 .Select(int.Parse)
                                 .ToList();

            int numberOfSets = int.Parse(Console.ReadLine());
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < numberOfSets; i++)
            {
                int[] set = Console.ReadLine()
                                 .Split(", ")
                                 .Select(int.Parse)
                                 .ToArray();

                result.Add(set);
            }
            var output = ChooseSets(result, universe);

            Console.WriteLine($"Sets to take ({ output.Count}):");

            foreach (var item in output)
            {
                Console.WriteLine($"{{ {string.Join(", ",item)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> result = new List<int[]>();

            while (sets.Count>0 && universe.Count > 0)
            {
                int[] largestSubsetOfUniverse = sets
                    .OrderByDescending(set => 
                    set.Count(el => 
                    universe.Contains(el)))
                    .FirstOrDefault();

                foreach (var item in largestSubsetOfUniverse)
                {
                    universe.Remove(item);

                }

                result.Add(largestSubsetOfUniverse);
                sets.Remove(largestSubsetOfUniverse);
            }

            return result;
        }
    }
}
