using System;
using SimUDuck.Behavior;
using SimUDuck.Models;

namespace SimUDuck_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.ReadKey();
        }

        static void Test()
        {
            Duck duck;

            duck = new MallardDuck();
            call();

            duck = new ModelDuck();
            call();

            var fly = new DuckFlyRocketPowered();
            duck.SetFlyBehavior(fly);
            call();

            void call()
            {
                duck.Display();
                duck.Swim();
                duck.PerformFly();
                duck.PerformQuack();

                Console.WriteLine();
            }
        }
    }
}
