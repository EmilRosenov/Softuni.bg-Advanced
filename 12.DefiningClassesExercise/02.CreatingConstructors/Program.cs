using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person(12);
            Console.WriteLine(personOne.Name);
            Console.WriteLine(personOne.Age);
        }
    }
}
