using System;
using System.IO;

namespace _07.StreamsFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                using (StreamWriter writer = new StreamWriter($"../../../student0{i + 1}.txt"))
                {

                    writer.WriteLine("Hi there, I am a new student");
                }
                
            }
           
        }
    }
}
