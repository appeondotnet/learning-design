using System;
using System.Runtime.InteropServices;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();

            WildTurkey wildTurkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Console.WriteLine("看看火鸡本身的行为！");

            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("再看看火鸡如何适配鸭子的行为");
            TestDuckBehavior(turkeyAdapter);

        }

        public static void TestDuckBehavior(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
