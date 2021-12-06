using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Copy("copyMe.png", "copyMe-copy.png");
            FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
            FileStream fileWriter = new FileStream("../../../copyMe-copy.png", FileMode.Create);
            byte[] arrayOfBytes = new byte[256];


            while (true)
            {
                int currentBytes = fileReader.Read(arrayOfBytes, 0, arrayOfBytes.Length);
                if (currentBytes == 0)
                {
                    fileWriter.Flush();
                    break;
                }
                fileWriter.Write(arrayOfBytes, 0, arrayOfBytes.Length);
                
            }
            Console.WriteLine("Done!");
        }
    }
}
