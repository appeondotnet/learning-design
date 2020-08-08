using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new NYPizzaStore();

            store.OrderPizza(PizzaStyle.Cheese);

            Console.ReadKey();
        }
    }
}
