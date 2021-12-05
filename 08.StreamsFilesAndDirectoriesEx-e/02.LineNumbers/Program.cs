using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    int counter = 1;
                    while (true)
                    {
                        int lettersCount = 0;
                        int punctuationsCount = 0;

                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }


                        for (int i = 0; i < line.Length; i++)
                        {
                            char letter = line[i];
                            if (char.IsLetter(letter))
                            {
                                lettersCount++;
                            }
                            if (char.IsPunctuation(letter))
                            {
                                punctuationsCount++;
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({lettersCount})({punctuationsCount})");
                        Console.WriteLine($"Line {counter}: {line} ({lettersCount})({punctuationsCount})");
                        counter++;
                    }
                }
            }
        }
    }
}
