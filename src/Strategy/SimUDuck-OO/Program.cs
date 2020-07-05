using System;
using SimUDuck.Models;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultTest();

            AddFlyTest();

            Console.ReadKey();
        }

        static void DefaultTest()
        {
            Duck duck;

            duck = new MallardDuck();
            call();

            duck = new ReadheadDuck();
            call();

            void call()
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                Console.WriteLine();
            }
        }

        static void AddFlyTest()
        {
            Duck duck;

            duck = new MallardDuck();
            call();

            duck = new ReadheadDuck();
            call();

            duck = new RubberDuck();
            call();

            duck = new DecoyDuck();
            call();

            void call()
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
                Console.WriteLine();
            }
        }
    }
}
