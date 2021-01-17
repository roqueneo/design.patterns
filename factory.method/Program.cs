using System;

namespace factory.method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello factory method!");
            Car streetCar = CarBuilder.Build(CarBuilder.STREET);
            PrintCar(streetCar);
            Car sportsCar = CarBuilder.Build(CarBuilder.SPORTS);
            PrintCar(sportsCar);
        }

        static void PrintCar(Car car)
        {
            Console.WriteLine($"This is a {car.Type} car");
        }
    }
}
