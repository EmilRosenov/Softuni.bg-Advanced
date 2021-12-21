using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {

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
