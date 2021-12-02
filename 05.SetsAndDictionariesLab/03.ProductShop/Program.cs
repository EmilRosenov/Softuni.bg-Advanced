using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0]=="Revision")
                {
                    var ordered = info.OrderBy(x => x.Key);
                    foreach (var shopName in ordered)
                    {
                        Console.WriteLine($"{shopName.Key}->");
                        foreach (var item in shopName.Value)
                        {
                            Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                        }
                    }
                    return;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!info.ContainsKey(shop))
                {
                    info.Add(shop, new Dictionary<string, double>());
                    info[shop].Add(product, price);
                }
                else if (info.ContainsKey(shop))
                {
                    info[shop].Add(product, price);
                }
            }
        }
    }
}
