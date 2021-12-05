using System;
using System.IO;

namespace _11.BasicVirus
{
    class Program
    {
        static void Main(string[] args)
        {
           string directoryPath =  Console.ReadLine();
            double sum = GetDirectySize(directoryPath);
            Console.WriteLine(sum);
        }
        static double GetDirectySize(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;
            string[] directories = Directory.GetDirectories(directoryPath);

            for (int i = 0; i < directories.Length; i++)
            {
                sum += GetDirectySize(directories[i]);
                //Directory.Delete(directories[i]); ** DO NOT RUN IT
            }
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{info.FullName} --> {info.Length} bytes");
                sum += info.Length;
                //File.Delete(files[i]); ** DO NOT RUN IT
            }

            return sum;
        }
    }
}
