using System;

namespace BoxOfT
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var box = new Box<string>();
            box.Add("Emil");
            box.Add("Pesho");
            box.Add("Gosho");
            box.Add("Niki");
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Count);
        }
    }
}
