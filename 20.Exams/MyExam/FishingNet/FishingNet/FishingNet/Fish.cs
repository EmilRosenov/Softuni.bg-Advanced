using System;

namespace FishingNet
{
    public class Fish
    {
        
        public Fish(string fishType,
                    double lenght,
                    double weight)
        {
            this.FishType = fishType;
            this.Lenght = lenght;
            this.Weight = weight;
        }

        public string FishType { get; set; }
        public double Lenght { get; set; }
        public double Weight { get; set; }
        public override string ToString()
        {
            return $"There is a {this.FishType}, {this.Lenght} cm. long, and {this.Weight} gr. in weight."; 
        }

    }
}
