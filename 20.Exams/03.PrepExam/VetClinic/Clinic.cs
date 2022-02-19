using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public List<Pet> data;

        public Clinic(int capacity)
        {
            data = new List<Pet>();
            Capacity = capacity;
            
        }

        public int Capacity { get; set; }
        
        public int Count => data.Count;

        public void Add(Pet pet)
        {
            if (data.Count<Capacity)
            {
                data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(x => x.Name == name);
            return data.Remove(pet);
            
        }

        public Pet GetPet(string name, string owner)
        {
            var pet = data.FirstOrDefault(x => x.Name == name && x.Owner == owner);

           
            return pet;
        }
        public Pet GetOldestPet()
        {
            Pet pet = data.OrderByDescending(x => x.Age).FirstOrDefault();
            return pet;


        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
