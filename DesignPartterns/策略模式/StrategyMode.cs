using System;
namespace DesignPartterns
{
    public abstract class Duck
    {
        public void PerformQuack(IQuackBehavior quackBehavior)
        {
            quackBehavior.Quack();
        }

        public void PerformFly(IFlyBehavior flyBehavior)
        {
            flyBehavior.Fly();
        }
    }

    public class GreenDuck : Duck
    {

    }

    public class RedDuck : Duck
    {

    }
}