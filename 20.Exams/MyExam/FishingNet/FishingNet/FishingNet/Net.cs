using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private readonly ICollection<Fish> fish;
        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.fish = new List<Fish>();
        }

        public string Material { get; set; }
        public int Capacity { get; set; }

        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)this.fish;

        public int Count => this.fish.Count;


        public string AddFish(Fish first)
        {
            //first = new Fish("name", 20.0, 1);
            if (string.IsNullOrWhiteSpace(first.FishType)
                                          || first.Weight <= 0
                                          || first.Lenght <= 0)
            {
                return "Invalid fish.";
            }

            if (Fish.Count + 1 > this.Capacity)
            {
                return "Fishing net is full.";

            }
            else
            {
                fish.Add(first);
                return $"Successfully added {first.FishType} to the fishing net.";
            }
        }

        public bool ReleaseFish(double weight)
        {
            var fishToRelease = this.fish.FirstOrDefault(e => e.Weight == weight);
            if (fishToRelease != null)
            {
                return this.fish.Remove(fishToRelease);
            }
            return false;
        }

        public Fish GetFish(string fishType)
        {
            Fish fishToReturn = fish.FirstOrDefault(f => f.FishType == fishType);
            return fishToReturn;
        }

        public Fish GetBiggestFish()
        {
            var orderedFish = fish.OrderByDescending(l => l.Lenght);
            Fish fishToReturn = orderedFish.FirstOrDefault();
            return fishToReturn;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            var orderedFish = fish.OrderByDescending(l => l.Lenght);
            sb.AppendLine($"Into the {this.Material}:");
            foreach (var item in orderedFish)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
