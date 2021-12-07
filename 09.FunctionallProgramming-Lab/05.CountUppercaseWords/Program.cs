using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> uppercaseWords = new List<string>();
            foreach (string word in text)
            {
                if (word.StartsWith(char.ToUpper(word[0])))
                {
                    uppercaseWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,uppercaseWords));
        }
    }
}
