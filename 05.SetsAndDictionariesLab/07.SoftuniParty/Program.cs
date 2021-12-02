using System;
using System.Collections.Generic;

namespace _07.SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipList = new HashSet<string>();
            var regularList = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();

                char first = input[0];
                if (char.IsDigit(first))  // or if(IsDigit(first))
                {
                    vipList.Add(input);
                }
                else if (input != "PARTY")
                {
                    regularList.Add(input);
                }

                if (input =="PARTY")
                {
                    break;
                }
               
            }

            string checkInput = Console.ReadLine();


            while (checkInput!="END")
            {
                if (vipList.Contains(checkInput))
                {
                    vipList.Remove(checkInput);
                }
                else if (regularList.Contains(checkInput))
                {
                    regularList.Remove(checkInput);
                }

                checkInput = Console.ReadLine();
            }
            int total = vipList.Count + regularList.Count;

            Console.WriteLine(total);
            foreach (var item in vipList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regularList)
            {
                Console.WriteLine(item);
            }
        }

        //private static bool IsDigit(char letter)
        //{
        //    return letter == 0 || letter == 1 || letter == 2 || letter == 3
        //         || letter == 4 || letter == 5 || letter == 6 || letter == 7
        //         || letter == 8 || letter == 9;
        //}
    }
}
