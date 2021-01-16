namespace prototype
{
    public class Mascot : ICloneable 
    {
        public Mascot(string name, int paws)
        {
            Name = name;
            Paws = paws;
        }

        public int Paws { get; set; }
        
        public string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}