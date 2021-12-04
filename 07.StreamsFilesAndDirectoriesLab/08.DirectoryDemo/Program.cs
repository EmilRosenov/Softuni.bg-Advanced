using System;
using System.IO;

namespace _08.DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine,Directory.GetFiles("../../../")));
            Console.WriteLine(Directory.Exists("../../../papkta"));
            Directory.CreateDirectory("../../../papkata");
            Console.WriteLine(Directory.Exists("../../../papkta"));
            Directory.Delete("../../../papkata");
        }
    }
}
