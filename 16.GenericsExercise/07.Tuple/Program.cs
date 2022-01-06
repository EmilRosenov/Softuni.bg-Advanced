using System;

namespace _07.Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] personDetails = Console.ReadLine().Split();
            string[] personBeersAmount = Console.ReadLine().Split();
            string[] numbers = Console.ReadLine().Split();

            string name = $"{personDetails[0]} {personDetails[1]}";
            string personAddress = personDetails[2];
            MyTuple<string, string> person =
                new MyTuple<string,string>(name,personAddress);

            string drinkersName = personBeersAmount[0];
            int litersBeer = int.Parse(personBeersAmount[1]);
            MyTuple<string, int> nameBeer =
                new MyTuple<string, int>(drinkersName, litersBeer);

            int number = int.Parse(numbers[0]);
            double doubleNumber = double.Parse(numbers[1]);
            MyTuple<int, double> numbersTuple =
                new MyTuple<int, double>(number, doubleNumber);


            Console.WriteLine(person.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(numbersTuple.GetItems());
        }
    }
}
