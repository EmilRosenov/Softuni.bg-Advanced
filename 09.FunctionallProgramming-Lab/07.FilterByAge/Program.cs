using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = line[0];
                person.Age = int.Parse(line[1]);
                people.Add(person);
            }
            
            string criteria = Console.ReadLine();
            int ageCriteria = int.Parse(Console.ReadLine());
            string[] printCriteria = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //List<Person> listAfterCriteria = new List<Person>();

            Func<Person, bool> filter = p => true;
           
            if (criteria == "younger")
            {
                filter = p => p.Age < ageCriteria;
            }
            else if (criteria == "older")
            {
                filter = p => p.Age >= ageCriteria;
            }

            var listAfterCriteria = people.Where(filter);
            foreach (var person in listAfterCriteria)
            {
                if (printCriteria.Length == 2)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (printCriteria[0] == "name")
                {
                    Console.WriteLine($"{person.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Age}");
                }
                
            }
        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
            
    }
}
