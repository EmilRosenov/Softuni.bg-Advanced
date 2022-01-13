using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person:IComparable<Person>
    {
        private string name;
        private int age;
        private string city;
        private int count;
        List<Person> personList = new List<Person>();
       
        
        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
            Count = count;
        }
        

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int Count { get; }

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result==0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            if (result == 0)
            {
                result = this.City.CompareTo(other.City);

            }

            return result;

        }

       
        
    }
}
