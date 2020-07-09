using System;
namespace DesignPartterns
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("FlyWithWings");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("FlyNoWay");
        }
    }
}
