using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocolateBoiler = ChocolateBoiler.GetInstance();

            chocolateBoiler.Fill();

            chocolateBoiler.Boil();

            chocolateBoiler.Drain();

            Console.ReadKey();
        }
    }
}
