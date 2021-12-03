using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{color} -> {item1},{item2},{item3}…"

            //If you receive a certain color, which already exists in your wardrobe,
            //just add the clothes to its records.

            int n = int.Parse(Console.ReadLine());
            var list = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                //Blue -> dress,jeans,hat
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];
                string[] clothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

               

                for (int j = 0; j < clothes.Length; j++)
                {
                   
                    string currentItem = clothes[j];

                    if (!list.ContainsKey(color))
                    {
                        list.Add(color, new Dictionary<string, int>());
                       
                    }
                    if (!list[color].ContainsKey(currentItem))
                    {
                        list[color].Add(currentItem, 0);
                    }

                    list[color][currentItem]++;
                }
            }
            string[] target = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            string targetColor = target[0];
            string targetItem = target[1];

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var element in item.Value)
                {
                    if (item.Key == targetColor && element.Key == targetItem)
                    {
                        Console.WriteLine($"* {element.Key} - {element.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {element.Key} - {element.Value}");
                    }
                }
            }
        }
    }
}
