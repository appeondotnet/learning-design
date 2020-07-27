using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITwoHoleTarget target = new ThreeToTwoAdapter();

            target.Request();

            ITurkey turkey = new WildTurkey();

            IDuck duck = new TurkeyAdapter(turkey);

            duck.Fly();

            duck.Quack();

            Console.Read();
        }
    }
}
