using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
        { 
        }

        public override void Display()
        {
            Console.WriteLine("This is RedHeadDuck");
        }
    }
}
