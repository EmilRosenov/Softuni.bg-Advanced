﻿using System;

namespace _05.DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            int output = dateModifier.CalculateDifference(startDate, endDate);
            Console.WriteLine(output);
        }
    }
}
