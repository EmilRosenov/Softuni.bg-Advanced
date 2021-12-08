using System;
using System.Linq;

namespace _05.UpperCaseWordsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var words = text.Where(word => char.IsUpper(word[0]));
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
