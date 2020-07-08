using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly with wings.");
        }
    }
}
