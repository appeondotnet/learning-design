using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorModelCase
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Const()
        {
            return .20 + _beverage.Const();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ",Whip";
        }
    }
}
