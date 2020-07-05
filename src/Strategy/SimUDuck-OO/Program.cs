using System;
using SimUDuck.Models;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalTest();

            Console.ReadKey();
        }

        static void NormalTest()
        {
            Duck duck;

            duck = new MallardDuck();
            call();

            duck = new ReadheadDuck();
            call();

            void call()
            {
                duck.Swim();
                duck.Quack();
                duck.Display();
            }
        }
    }
}
