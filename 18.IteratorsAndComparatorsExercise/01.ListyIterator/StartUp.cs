using System;
using System.Linq;

namespace _01.ListyIterator
{
    public class SrartUp
    {
        public static void Main(string[] args)
        {
            string command = "";
            ListyIterator<string> listy = null;
           

            while ((command = Console.ReadLine())!="END")
            {
                var token = command.Split();
                if (token[0]=="Create")
                {
                    listy = new ListyIterator<string>(token.Skip(1).ToArray());
                }
                else if (token[0] =="HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (token[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (token[0] == "Print")
                {
                    listy.Print();
                }
            }

            //string[] array = new string[command.Length - 1];
            //for (int i = 0; i < command.Length - 1; i++)
            //{
            //    array[i] = command[i + 1];
            //}

            //ListyIterator<string> listy = new ListyIterator<string>(array);
        }
    }
}
