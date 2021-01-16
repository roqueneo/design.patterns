using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singleton!");
            Console.WriteLine(Singleton.Instance.Message);
            Singleton.Instance.Message = "I'm the same singleton";
            Console.WriteLine(Singleton.Instance.Message);
        }
    }
}
