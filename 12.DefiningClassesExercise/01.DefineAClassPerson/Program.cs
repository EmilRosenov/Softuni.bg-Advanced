using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Peter", 20);
            Person personTwo = new Person();
            personTwo.Name = "George";
            personTwo.Age = 18;
            Person personThree = new Person("Jose", 43);

            Console.WriteLine($"{ personOne.Name} {personOne.Age}");
            Console.WriteLine($"{ personTwo.Name} {personTwo.Age}");
            Console.WriteLine($"{ personThree.Name} {personThree.Age}");
        }
    }
}
