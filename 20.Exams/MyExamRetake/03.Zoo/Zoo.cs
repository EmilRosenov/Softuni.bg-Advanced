using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private readonly List<Animal> animals;

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            animals = new List<Animal>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.animals.Count;
        public IReadOnlyCollection<Animal> Animals => this.animals;

        public string AddAnimal(Animal animal)
        {
            if (animals.Count+1 > this.Capacity)
            {
                return "The zoo is full.";
            }
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            animals.Add(animal);
            
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int removed = 0;
            int total = animals.Count;

            animals.RemoveAll(x => x.Species == species);
            removed = total - animals.Count;
            return removed;
            
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalsByDietList = new List<Animal>();

            foreach (var item in animals)
            {
                if (item.Diet == diet)
                {
                    animalsByDietList.Add(item);
                }

            }

            return animalsByDietList;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal theOne = animals.FirstOrDefault(w => w.Weight == weight);
            return theOne;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            List<Animal> animalsCountByLength = new List<Animal>();

            foreach (var item in animals)
            {
                if (item.Length >= minimumLength && item.Length <= maximumLength)
                {
                    animalsCountByLength.Add(item);
                }
            }

            return $"There are {animalsCountByLength.Count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
