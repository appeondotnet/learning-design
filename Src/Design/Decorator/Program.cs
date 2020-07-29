using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage darkRost = new DarkRost(10);

            darkRost.Size = BeverageSize.LARGE;

            Decorator milk = new Milk(darkRost);

            Decorator mocha = new Mocha(milk);

            Console.WriteLine($"{mocha.Description} : {mocha.Cost} ({mocha.Size.ToString()})");

            Console.ReadKey();
        }
    }
}
