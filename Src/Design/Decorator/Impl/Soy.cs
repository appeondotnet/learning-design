using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Soy : Decorator
    {
        public Soy(IBeverage beverage) : base(beverage)
        { 
        }

        public override string Description
        {
            get
            {
                return _beverage.Description + ", Soy";
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
                            return _beverage.Cost + 3;
                        }
                    case BeverageSize.LARGE:
                        {
                            return _beverage.Cost + 5;
                        }
                    default:
                        return _beverage.Cost + 2;
                }
            }
        }
    }
}
