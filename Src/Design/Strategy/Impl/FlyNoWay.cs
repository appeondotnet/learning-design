using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cant fly");
        }
    }
}
