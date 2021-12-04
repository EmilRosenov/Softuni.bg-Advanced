using System;
using System.IO;

namespace _04.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    string line = reader.ReadLine();
                    int counter = 1;
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}.  {line}");

                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
