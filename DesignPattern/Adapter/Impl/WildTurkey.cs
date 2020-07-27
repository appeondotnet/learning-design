using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }
    }
}
