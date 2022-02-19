using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first line of input will represent the ingredients' values
            //- integers, separated by single space

            //On the second line you will be given the freshness values
            //- integers again, separated by single space

            var createdDishesTypesAndCount = new Dictionary<string, int>();

            int[] ingredientValues = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            int[] freshnessValue = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            Queue<int> valuesQueue = new Queue<int>();
            Stack<int> freshnessValueStack = new Stack<int>();

            for (int i = 0; i < ingredientValues.Length; i++)
            {
                valuesQueue.Enqueue(ingredientValues[i]);

            }
            for (int i = 0; i < freshnessValue.Length; i++)
            {
                freshnessValueStack.Push(freshnessValue[i]);

            }

            while (valuesQueue.Count > 0 && freshnessValueStack.Count > 0)
            {
                if (valuesQueue.Peek() == 0)
                {
                    valuesQueue.Dequeue();
                    continue;
                }
                //if (freshnessValueStack.Peek() == 0)
                //{
                //    freshnessValueStack.Pop();
                //    continue;
                //}

                if (valuesQueue.Peek() * freshnessValueStack.Peek() == 150)
                {
                    string dishType = "Dipping sauce";
                    if (!createdDishesTypesAndCount.ContainsKey(dishType))
                    {
                        createdDishesTypesAndCount.Add(dishType, 1);
                    }
                    else
                    {
                        createdDishesTypesAndCount[dishType] += 1;
                    }

                    valuesQueue.Dequeue();
                    freshnessValueStack.Pop();
                }
                else if (valuesQueue.Peek() * freshnessValueStack.Peek() == 250)
                {
                    string dishType = "Green salad";
                    if (!createdDishesTypesAndCount.ContainsKey(dishType))
                    {
                        createdDishesTypesAndCount.Add(dishType, 1);
                    }
                    else
                    {
                        createdDishesTypesAndCount[dishType] += 1;
                    }

                    valuesQueue.Dequeue();
                    freshnessValueStack.Pop();
                }
                else if (valuesQueue.Peek() * freshnessValueStack.Peek() == 300)
                {
                    string dishType = "Chocolate cake";
                    if (!createdDishesTypesAndCount.ContainsKey(dishType))
                    {
                        createdDishesTypesAndCount.Add(dishType, 1);
                    }
                    else
                    {
                        createdDishesTypesAndCount[dishType] += 1;
                    }

                    valuesQueue.Dequeue();
                    freshnessValueStack.Pop();
                }
                else if (valuesQueue.Peek() * freshnessValueStack.Peek() == 400)
                {
                    string dishType = "Lobster";
                    if (!createdDishesTypesAndCount.ContainsKey(dishType))
                    {
                        createdDishesTypesAndCount.Add(dishType, 1);
                    }
                    else
                    {
                        createdDishesTypesAndCount[dishType] += 1;
                    }

                    valuesQueue.Dequeue();
                    freshnessValueStack.Pop();
                }

                else
                {
                    freshnessValueStack.Pop();

                    int newFreshnessValue = valuesQueue.Peek() + 5;
                    valuesQueue.Dequeue();
                    valuesQueue.Enqueue(newFreshnessValue);
                }
            }

            if (createdDishesTypesAndCount.Keys.Count >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (valuesQueue.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {valuesQueue.Sum()}");
            }
            var sortedDishesTypesAndCount = createdDishesTypesAndCount
                                            .OrderBy(x => x.Key)
                                            .ThenByDescending(y => y.Value)
                                            .ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in sortedDishesTypesAndCount)
            {
                Console.WriteLine($"# {item.Key} --> {item.Value}");
            }

        }
    }
}
