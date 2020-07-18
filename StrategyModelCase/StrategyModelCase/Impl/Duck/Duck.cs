using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyModelCase
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;


        public virtual void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public virtual void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public virtual void SetFlyBehavior(IFlyBehavior behavior)
        {
            _flyBehavior = behavior;
        }
        public virtual void SetQuackBehavior(IQuackBehavior behavior)
        {
            _quackBehavior = behavior;
        }
    }
}
