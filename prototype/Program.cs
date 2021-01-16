using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello prototype!");
            Mascot marshal = new Mascot("Marshal", 4);
            // Bad clone
            Mascot sky = marshal;
            // Right clone
            Mascot everest = marshal.Clone() as Mascot;
            sky.Name = "Sky";
            everest.Name = "Everest";
            PrintMascot(marshal);
            PrintMascot(sky);
            PrintMascot(everest);
        }

        static void PrintMascot(Mascot mascot)
        {
            Console.WriteLine($"I'm {mascot.Name}");
        }
    }
}
