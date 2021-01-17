using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello prototype!");
            Mascot dolly = new Mascot("Dolly", "Sheep", 4);
            dolly.Vehicle = new Vehicle() { Type = "Car", Color = "White" };
            Console.WriteLine("Prototype Pattern...");
            // Bad clone
            Mascot sky = dolly;
            // Right clone
            Mascot everest = dolly.Clone() as Mascot;
            sky.Name = "Sky";
            sky.Species = "Dog";
            everest.Name = "Everest";
            everest.Species = "Dog";
            if (everest.HasVehicle())
                everest.Vehicle.Color = "Green";
            PrintMascot(nameof(dolly), dolly);
            PrintMascot(nameof(sky), sky);
            PrintMascot(nameof(everest), everest);
        }

        static void PrintMascot(string instaceName, Mascot mascot)
        {
            Console.WriteLine($"{instaceName.ToUpper()} says:");
            Console.Write($" » I'm a {mascot.Species} called {mascot.Name} and I've {mascot.Paws} paws.");
            if (mascot.Vehicle != null)
                Console.WriteLine($" And I drive a {mascot.Vehicle.Color} {mascot.Vehicle.Type}");
        }
    }
}
