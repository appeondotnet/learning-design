using System;

namespace DecoratorModelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new DarkRoast();

            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Const());

            Console.ReadKey();
        }
    }
}
