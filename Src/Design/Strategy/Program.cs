using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var flyBehavior = new FlyWithWings();
            var quackBehavior = new MuteQuack();

            var duck = new DecoyDuck(flyBehavior, quackBehavior);

            duck.Display();
            
            duck.Fly();

            duck.Quack();

            Console.ReadKey();
        }
    }
}
