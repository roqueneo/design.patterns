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

        public Vehicle Vehicle { get; set; }

        public bool HasVehicle()
            => Vehicle != null;

        public object Clone()
        {
            Mascot clone = MemberwiseClone() as Mascot;
            if (HasVehicle())
                clone.Vehicle = Vehicle.Clone() as Vehicle;
            return clone;
        }
    }

    public class Vehicle : ICloneable
    {
        public string Type { get; set; }

        public string Color { get; set; }

        public object Clone()
            => MemberwiseClone();
    }
}