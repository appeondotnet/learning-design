using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class QuackLoudly : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack loudly.");
        }
    }
}
