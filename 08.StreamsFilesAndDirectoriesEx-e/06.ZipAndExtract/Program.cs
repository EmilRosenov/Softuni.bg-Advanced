using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\Sony Vaio\Desktop\Homework";
            string targetDirectory = @"C:\Users\Sony Vaio\Desktop\Target\result123.zip";
            string resultDirectory = @"C:\Users\Sony Vaio\Desktop\Result";

            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, resultDirectory);
           
        }
    }
}
