using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Behavior;

namespace SimUDuck.Models
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _quack = new DuckQuack();
            _fly = new DuckFlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("ModelDuck: Display.");
        }
    }
}
