using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        //public List<Person> people = new List<Person>();

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
            : this()
        {

            Age = age;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }

        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;

            }

        }

       
    }
   
}