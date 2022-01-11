﻿using System;
using System.Linq;

namespace _02.Colllection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = "";
            ListyIterator<string> listy = null;


            while ((command = Console.ReadLine()) != "END")
            {
                var token = command.Split();
                if (token[0] == "Create")
                {
                    listy = new ListyIterator<string>(token.Skip(1).ToArray());
                }
                else if (token[0] == "HasNext")
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
                else if (token[0] == "PrintAll")
                {
                    listy.PrintAll();
                }
            }
        }
    }
}
