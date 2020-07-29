using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Beverage : IBeverage
    {
        public Beverage(decimal cost)
        {
            this.Cost = cost;
        }

        public string Description { get; protected set; }

        public BeverageSize Size { get; set; }

        public virtual decimal Cost { get; private set; }
    }
}
