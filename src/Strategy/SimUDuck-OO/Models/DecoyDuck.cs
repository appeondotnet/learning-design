using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Models
{
    public class DecoyDuck : Duck
    {
        public new void Quack()
        {
            Console.WriteLine("DecoyDuck: Quack(zz).");
        }

        public override void Display()
        {
            Console.WriteLine("DecoyDuck: Display.");
        }

        public new void Fly()
        {
            Console.WriteLine("DecoyDuck: Fly(no fly).");
        }
    }
}
