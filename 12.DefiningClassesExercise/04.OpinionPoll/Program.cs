using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //1.create class Person
            //2.Add the object to a collection
            //3.Print each element from the collection, where the criteria is met

            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string name = inputInfo[0];
                int age = int.Parse(inputInfo[1]);

                Person someBody = new Person(name, age);
                people.Add(someBody);

            }

            List<Person> over30s = new List<Person>();
            over30s = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (Person person in over30s)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
