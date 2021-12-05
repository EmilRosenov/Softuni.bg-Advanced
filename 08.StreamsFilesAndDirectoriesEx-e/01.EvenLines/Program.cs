using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string symbolToReplace = "-,.!?";
                    int counter = 0;
                    string[] specialSymbols = new string[] { "-", ",", ".", "!", "?" };
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line==null)
                        {
                            break;
                        }

                        foreach (var symbol in symbolToReplace)
                        {
                            line = line.Replace(symbol, '@');
                        }
                        if (counter % 2 == 0)
                        {
                            Console.WriteLine(string.Join(" ", line.Split().Reverse()));
                            writer.WriteLine(line.Reverse());
                        }

                        counter++;
                    }
                }

            }
        }
    }
}
