using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class QuackMute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack.");
        }
    }
}
