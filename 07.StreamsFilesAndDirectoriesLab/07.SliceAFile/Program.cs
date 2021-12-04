using System;
using System.IO;

namespace _07.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[10496];
            int slicePartitions = 4;
            using (FileStream reader = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                var size = reader.Length / slicePartitions;
                
                
                for (int i = 0; i < slicePartitions; i++)
                {
                    using (FileStream creator = new FileStream($"../../../Part{i+1}.txt", FileMode.Create))
                    {
                        int counter = 0; 
                        while (counter < size)
                        {
                            reader.Read(buffer, 0, buffer.Length);
                            creator.Write(buffer, 0, buffer.Length);
                            counter += buffer.Length;
                        }
                       
                    }
                }
            }
        }
    }
}


