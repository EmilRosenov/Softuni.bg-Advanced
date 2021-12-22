using System;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family familyMembers = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string personName = inputInfo[0];
                int personAge = int.Parse(inputInfo[1]);

                Person familyMember = new Person(personName, personAge);
                familyMembers.AddMemeber(familyMember);
               
            }

            var oldestMember = familyMembers.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            
        }
    }
}
