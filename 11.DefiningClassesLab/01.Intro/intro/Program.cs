using System;
using System.Linq;

namespace intro
{
    class Program
    {
        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public int[] Grades { get; set; }
        }
        static void Main(string[] args)
        {
            Person[] people = new Person[100];
            people[0] = new Person();
            people[0].Grades = new int[] { 4, 5, 6, 6 };
            people[0].Name = "Emil";
            people[0].Age = 33;

            people[53] = new Person();
            people[53].Grades = new int[] { 4, 4, 4, 5 };
            people[53].Name = "Ivan";
            people[53].Age = 32;

            people[11] = new Person();
            people[11].Grades = new int[] { };
            people[11].Name = null;
            people[11].Age = 0;

            //people[53].Name = null;
            //people[53].Age = 0;

            Console.WriteLine($"{people[0].Name}, who is at the age of" +
                $" {people[0].Age} and has scores of {string.Join(", ",people[0].Grades)}");
            Console.WriteLine($"{people[53].Name}, who is at the age of" +
                $" {people[53].Age} and has scores of {string.Join(", ", people[53].Grades)}");
            Console.WriteLine($"{people[11].Name}, who is at the age of" +
                $" {people[11].Age} and has scores of {string.Join(", ", people[11].Grades)}");

        }
    }
}
