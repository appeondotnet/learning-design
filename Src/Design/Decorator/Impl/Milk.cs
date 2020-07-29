using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Milk : Decorator
    {
        public Milk(IBeverage beverage) : base(beverage)
        {
        }

        public override string Description
        {
            get
            {
                return _beverage.Description + ", Milk";
            }
        }

        public override decimal Cost
        {
            get
            {
                if (this.Size == BeverageSize.SMALL)
                {
                    return _beverage.Cost + 2;
                }
                else if (this.Size == BeverageSize.MIDDLE)
                {
                    return _beverage.Cost + 5;
                }
                else if (this.Size == BeverageSize.LARGE)
                {
                    return _beverage.Cost + 7;
                }

                return _beverage.Cost;
            }
        }
    }
}
