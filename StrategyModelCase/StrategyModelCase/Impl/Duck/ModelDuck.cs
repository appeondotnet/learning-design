using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyModelCase
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new DuckQuack();
        }
    }
}
