using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new ZhouHeiDuck();

            duck.Display();

            IFlyBehavior behavior = new FlyWithWings();

            duck.SetFlyBehavoir(behavior);

            Console.WriteLine("Set fly feature.");

            duck.PerformFly();

            Console.Read();
        }
    }
}
