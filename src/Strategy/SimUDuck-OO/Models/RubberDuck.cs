using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Models
{
    public class RubberDuck : Duck
    {
        public new void Quack()
        {
            Console.WriteLine("RubberDuck: Quack(no quack).");
        }

        public override void Display()
        {
            Console.WriteLine("DecoyDuck: Display.");
        }

        public new void Fly()
        {
            Console.WriteLine("RubberDuck: Fly(no fly).");
        }
    }
}
