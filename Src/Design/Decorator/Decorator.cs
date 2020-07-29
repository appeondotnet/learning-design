using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Decorator : IBeverage
    {
        protected IBeverage _beverage;

        public Decorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public abstract string Description { get; }

        public abstract decimal Cost { get; }

        public BeverageSize Size => _beverage.Size;
    }
}
