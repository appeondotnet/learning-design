using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Behavior;

namespace SimUDuck.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quack = new DuckQuack();
            _fly = new DuckFlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("MallardDuck: Display.");
        }
    }
}
