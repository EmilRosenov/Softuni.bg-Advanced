using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mealsInput = Console.ReadLine()
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                        .ToArray(); 
            int[] daylyCalorieIntakeInput = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray();
            Queue<string> mealsQueue = new Queue<string>();
            Stack<int> daylyCalorieIntakeList = new Stack<int>();
            int mealsEaten = 0;

            foreach (var item in mealsInput)
            {
                mealsQueue.Enqueue(item);
            }
            foreach (var item in daylyCalorieIntakeInput)
            {
                daylyCalorieIntakeList.Push(item);
            }

            while (mealsQueue.Count>0 && daylyCalorieIntakeList.Count>0)
            {
                int currentDayCalories = daylyCalorieIntakeList.Peek();

                if (mealsQueue.Peek() == "salad")
                {
                    currentDayCalories -= 350;

                }
                else if (mealsQueue.Peek() == "soup")
                {
                    currentDayCalories -= 490;
                }
                else if (mealsQueue.Peek() == "pasta")
                {
                    currentDayCalories -= 680;
                }
                else if (mealsQueue.Peek() == "steak")
                {
                    currentDayCalories -= 790;
                }
                
                
                if (currentDayCalories>0)
                {
                    daylyCalorieIntakeList.Pop();
                    daylyCalorieIntakeList.Push(currentDayCalories);
                }
                else
                {
                    daylyCalorieIntakeList.Pop();
                    
                    if (daylyCalorieIntakeList.Count<1)
                    {
                        mealsEaten++;
                        mealsQueue.Dequeue();
                        break;
                    }
                    
                    
                    int previousDayCalories = Math.Abs(currentDayCalories);
                    int newSum = daylyCalorieIntakeList.Peek() - previousDayCalories;
                    daylyCalorieIntakeList.Pop(); 
                    daylyCalorieIntakeList.Push(newSum);
                }
                mealsQueue.Dequeue();
                mealsEaten++;

            }

            if (mealsQueue.Count==0)
            {
                Console.WriteLine($"John had {mealsInput.Length} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", daylyCalorieIntakeList)} calories.");
            }
            else 
            {
                Console.WriteLine($"John ate enough, he had {mealsEaten} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", mealsQueue)}.");
            }
            
        }
    }
}
