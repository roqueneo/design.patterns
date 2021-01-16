using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello prototype!");
            Console.WriteLine("Shallow Prototype Pattern...");
            Mascot dolly = new Mascot("Dolly", "Sheep", 4);
            // Bad clone
            Mascot sky = dolly;
            // Right clone
            Mascot everest = dolly.Clone() as Mascot;
            sky.Name = "Sky";
            sky.Species = "Dog";
            everest.Name = "Everest";
            everest.Species = "Dog";
            PrintMascot(nameof(dolly), dolly);
            PrintMascot(nameof(sky), sky);
            PrintMascot(nameof(everest), everest);
        }

        static void PrintMascot(string instaceName, Mascot mascot)
        {
            Console.WriteLine($"{instaceName.ToUpper()} says:");
            Console.WriteLine($" » I'm a {mascot.Species} called {mascot.Name} and I've {mascot.Paws} paws.");
        }
    }
}
