using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoy!");
        }

        public abstract void Display();
    }
}
