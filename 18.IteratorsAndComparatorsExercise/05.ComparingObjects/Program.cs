using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> citizenList = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0]=="END")
                {
                    break;
                }

                string name = input[0];
                int age = int.Parse(input[1]);
                string city = input[2];

                Person citizen = new Person(name, age, city);
                citizenList.Add(citizen);

            }

            int index = int.Parse(Console.ReadLine())-1;

            int equals = 0;
            int different = 0;

            foreach (Person item in citizenList)
            {
                if (citizenList[index].CompareTo(item) ==0)
                {
                    equals++;
                }
                else
                {
                    different++;
                }
                
            }

            if (equals<=1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equals} {different} {citizenList.Count}");
                
            }
        }
    }
}
