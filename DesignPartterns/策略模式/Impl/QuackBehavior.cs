using System;
namespace DesignPartterns
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("MuteQuack");
        }
    }
}
