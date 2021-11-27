using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentsGradesInfo = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                //John 5.20
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = input[0];
                decimal studentGrade = decimal.Parse(input[1]);

                if (!studentsGradesInfo.ContainsKey(studentName))
                {
                    studentsGradesInfo.Add(studentName, new List<decimal>());
                    studentsGradesInfo[studentName].Add(studentGrade);
                }
                else
                {
                    studentsGradesInfo[studentName].Add(studentGrade);
                }
            }

            foreach (var item in studentsGradesInfo)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {item.Value.Average():f2})");
                Console.WriteLine();
                   
            }

            //foreach (var (name,grade) in studentsGradesInfo)
            //{
            //    Console.WriteLine($"{name} -> {string.Join(" ",grade)} (avg: {grade.Average():f2})");
            //}
        }
    }
}
