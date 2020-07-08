using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ZhouHeiDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am zhouheiya, i can't fly and quack.");
        }
    }
}
