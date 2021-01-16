using System;

namespace prototype
{
    public class Mascot : ICloneable 
    {
        public Mascot(string name, string species, int paws)
        {
            Name = name;
            Species = species;
            Paws = paws;
        }

        public string Species { get; set; }
        
        public int Paws { get; set; }
        
        public string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Color { get; set; }
    }
}