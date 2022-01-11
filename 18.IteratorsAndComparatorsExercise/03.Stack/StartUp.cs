using System;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                     .Split(new char[] {' ', ','},StringSplitOptions.RemoveEmptyEntries);
            int[] numbersArray = new int[input.Length - 1];

            for (int i = 0; i < input.Length-1; i++)
            {
                numbersArray[i] = int.Parse(input[i+1]);
            }

            CustomStack<int> customStack = new CustomStack<int>();

            while (input[0]!="END")
            {
                
                if (input[0]=="Push")
                {
                   
                    customStack.Push(numbersArray);
                }
                else if (input[0] =="Pop")
                {
                    customStack.Pop();
                }

                input = Console.ReadLine().Split();

                numbersArray = new int[input.Length - 1];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    numbersArray[i] = int.Parse(input[i + 1]);
                }

            }

            foreach (var item in customStack.ToList())
            {
                if (customStack.Count==0)
                {
                    throw new ArgumentException("No elements");
                }

                Console.WriteLine(item);
            }
            foreach (var item in customStack.ToList())
            {
                if (customStack.Count == 0)
                {
                    throw new ArgumentException("No elements");
                }

                Console.WriteLine(item);
            }
        }
    }
}
