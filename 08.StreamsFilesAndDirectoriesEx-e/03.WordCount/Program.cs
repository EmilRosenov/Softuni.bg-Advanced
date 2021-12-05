using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("../../../words.txt"))
            {

                using (var readerTwo = new StreamReader("../../../text.txt"))
                {
                    string word = reader.ReadLine();
                    while (word != null)
                    {
                        if (!result.ContainsKey(word))
                        {
                            result.Add(word, 0);
                        }
                        word = reader.ReadLine();
                    }


                    string[] input = readerTwo
                   .ReadToEnd()
                   .ToLower().Split();

                    foreach (var wordInText in input)
                    {
                        if (wordInText == "")
                        {
                            continue;
                        }
                        string trimmed = "";
                        if (char.IsPunctuation(wordInText[0]) && char.IsPunctuation(wordInText[wordInText.Length - 1]))
                        {
                            trimmed = wordInText.TrimStart(wordInText[0]).TrimEnd(wordInText[wordInText.Length - 1]);

                            if (result.ContainsKey(trimmed))
                            {
                                result[trimmed]++;
                            }
                        }

                        else if (char.IsPunctuation(wordInText[0]))
                        {
                            trimmed = wordInText.TrimStart(wordInText[0]);
                            if (result.ContainsKey(trimmed))
                            {
                                result[trimmed]++;
                            }

                        }
                        else if (char.IsPunctuation(wordInText[wordInText.Length - 1]))
                        {
                            trimmed = wordInText.TrimEnd(wordInText[wordInText.Length - 1]);
                            if (result.ContainsKey(trimmed))
                            {
                                result[trimmed]++;
                            }
                        }


                        if (result.ContainsKey(wordInText))
                        {
                            result[wordInText]++;
                        }
                    }
                }


                using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
                {
                    foreach (var item in result.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{item.Key} - {item.Value}");
                        Console.WriteLine($"{item.Key} - {item.Value}");

                    }
                }
            }
        }
    }
}
