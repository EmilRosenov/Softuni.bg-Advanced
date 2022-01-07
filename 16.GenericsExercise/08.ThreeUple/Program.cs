using System;
using System.Text;

namespace _08.ThreeUple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            string[] thirdInput = Console.ReadLine().Split();

            string name = $"{firstInput[0]} {firstInput[1]}";
            string street = firstInput[2];
            StringBuilder sb = new StringBuilder();
            for (int i = 3; i < firstInput.Length; i++)
            {
                sb.Append(firstInput[i] + " ");
            }
            string city = sb.ToString().TrimEnd();

            ThreeUple<string, string, string> nameStreetCity =
                new ThreeUple<string, string, string>(name, street, city);
            Console.WriteLine(nameStreetCity.GetItems());

            string beerDrinkersName = secondInput[0];
            int drinksNeeded = int.Parse(secondInput[1]);
            bool drunkOrNot = secondInput[2] =="drunk";
            ThreeUple<string,int, bool> beerNameAmountState = 
                new ThreeUple<string, int, bool>
                (beerDrinkersName, drinksNeeded, drunkOrNot);
            Console.WriteLine(beerNameAmountState.GetItems());


            string nameTwo = thirdInput[0];
            double doubleNumber = double.Parse(thirdInput[1]);
            string workplace = thirdInput[2];
            ThreeUple<string, double, string> nameAmountWorkPlace =
                new ThreeUple<string, double, string>
                (nameTwo, doubleNumber, workplace);
            Console.WriteLine(nameAmountWorkPlace.GetItems());


        }
    }
}
