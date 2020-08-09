using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorModelCase
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Const()
        {
            return .30 + _beverage.Const();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ",Mocha";
        }
    }
}
