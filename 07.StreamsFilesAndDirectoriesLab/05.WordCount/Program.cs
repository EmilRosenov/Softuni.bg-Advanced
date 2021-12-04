using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            using (StreamReader readerOne = new StreamReader("../../../words.txt"))
            {
                using (StreamReader readerTwo = new StreamReader("../../../text.txt"))
                {
                    string[] line = readerOne.ReadLine().ToLower()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in line)
                    {
                        if (!dict.ContainsKey(word))
                        {
                            dict.Add(word, 0);
                        }
                    }

                    string[] text = readerTwo.ReadToEnd().ToLower()
                        .Split();
                        
                    
                    foreach (string item in text)
                    {
                        string word = item;
                        if (word =="")
                        {
                            continue;
                        }
                        if (char.IsPunctuation(item[0]))
                        {
                            word = item.TrimStart(item[0]);
                           
                        }
                        if (char.IsPunctuation(item[item.Length-1]))
                        {
                            word = word.TrimEnd(item[item.Length-1]);
                        }

                        if (dict.ContainsKey(word))
                        {
                            dict[word]++;
                        }

                        
                    }

                    using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                    {
                        foreach (var item in dict.OrderByDescending(v => v.Value))
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
                   
            }
        
        }
    }
}
