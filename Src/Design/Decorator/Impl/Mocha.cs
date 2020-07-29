using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Decorator
{
    public class Mocha : Decorator
    {
        public Mocha(IBeverage beverage) : base(beverage)
        {
        }

        public override string Description
        {
            get
            {
                return _beverage.Description + ", Mocha";
            }
        }

        public override decimal Cost
        {
            get
            {
                switch (this.Size)
                {
                    case BeverageSize.SMALL:
                        {
                            return _beverage.Cost + 2;
                        }
                    case BeverageSize.MIDDLE:
                        {
                            return _beverage.Cost + 5;
                        }
                    case BeverageSize.LARGE:
                        {
                            return _beverage.Cost + 7;
                        }
                    default:
                        return _beverage.Cost + 2;
                }
            }
        }
    }
}
