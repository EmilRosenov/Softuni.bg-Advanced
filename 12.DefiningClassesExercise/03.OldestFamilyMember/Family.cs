using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        
        //public List<Person> familyMembers { get; set; }

        List<Person> familyMembers = new List<Person>();


        public void AddMemeber(Person member)
        {
            familyMembers.Add(member);
            
        }

        public Person GetOldestMember()
        {
            List<Person> sortedFamilyMembers = new List<Person>();
            sortedFamilyMembers = familyMembers.OrderByDescending(x => x.Age).ToList();
            var oldestMember = sortedFamilyMembers.FirstOrDefault();
            return oldestMember;
        }
    }
}
