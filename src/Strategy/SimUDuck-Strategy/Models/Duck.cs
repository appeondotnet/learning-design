using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Behavior;

namespace SimUDuck.Models
{
    public abstract class Duck
    {
        protected IDuckFlyBehavior _fly;
        protected IDuckQuackBehavior _quack;

        public void Swim()
        {
            Console.WriteLine("Duck: Swim.");
        }

        public void PerformQuack()
        {
            _quack.Quack();
        }

        public void PerformFly()
        {
            _fly.Fly();
        }

        public void SetFlyBehavior(IDuckFlyBehavior fly)
        {
            _fly = fly;
        }

        public void SetQuackBehavior(IDuckQuackBehavior quack)
        {
            _quack = quack;
        }

        public abstract void Display();
    }
}
