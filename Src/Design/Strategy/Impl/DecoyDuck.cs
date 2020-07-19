using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
        { 
        }

        public override void Display()
        {
            Console.WriteLine("This is Decoy duck");
        }
    }
}
