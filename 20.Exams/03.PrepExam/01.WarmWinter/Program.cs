using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> hats = new Stack<int>(firstInput);
            Queue<int> scarves = new Queue<int>(secondInput);
            List<int> priceList = new List<int>();
            
            while (hats.Count>0 && scarves.Count>0)
            {
                int hat = hats.Peek();
                int scarf = scarves.Peek();
                if (hat > scarf)
                {
                    int price = hat + scarf;
                    priceList.Add(price);

                    hats.Pop();
                    scarves.Dequeue();
                }
                else if (scarf > hat)
                {
                    hats.Pop();
                }
                else if (scarf == hat)
                {
                    scarves.Dequeue();
                    int incrementation = hats.Pop()+1;
                    hats.Push(incrementation);

                }
            }
            Console.WriteLine($"The most expensive set is: {priceList.Max()}");
            Console.WriteLine(string.Join(" ", priceList));
        }
    }
}
