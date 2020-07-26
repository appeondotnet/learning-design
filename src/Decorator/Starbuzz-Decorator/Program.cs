using System;

namespace Starbuzz_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();

            beverage = new Mocha(beverage);

            Console.WriteLine(beverage.Cost());

            Console.ReadKey();
        }
    }
}
