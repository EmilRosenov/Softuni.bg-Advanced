using System;
using System.IO;

namespace _09.CalculateFolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\Sony Vaio\Desktop\Softuni\Advanced\07.StreamsFilesAndDirectoriesLab\07.StreamsFilesAndDirectories\09.CalculateFolderSize\06. Folder Size\TestFolder\TestFolder2\";
            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{ info.FullName} --> {info.Length} bytes");
                sum += info.Length;
            }

            Console.WriteLine(sum/1024/1024);
        }
    }
}
