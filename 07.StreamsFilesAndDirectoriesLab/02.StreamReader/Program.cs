using System;
using System.IO;

namespace _02.StreamReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader(@"C:\Users\Sony Vaio\Desktop\Softuni\Advanced\07.StreamsFilesAndDirectoriesLab\07.StreamsFilesAndDirectories\07.StreamsFilesAndDirectories\student.txt"))
            {

                string text = reader.ReadLine();

                string fullText = reader.ReadToEnd();
                Console.WriteLine(fullText);
                

               using (StreamWriter writer = new StreamWriter("../../../input.txt"))
               {

                    writer.Write(fullText);
               
               }
            }
            

            
        }
    }
}
