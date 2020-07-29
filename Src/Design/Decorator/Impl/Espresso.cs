using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Espresso : Beverage
    {
        public Espresso(decimal cost) : base(cost)
        {
            this.Description = "Espresso coffee";
        }

        public override decimal Cost
        {
            get
            {
                switch (this.Size)
                {
                    case BeverageSize.SMALL:
                        {
                            return base.Cost;
                        }
                    case BeverageSize.MIDDLE:
                        {
                            return base.Cost + 2;
                        }
                    case BeverageSize.LARGE:
                        {
                            return base.Cost + 5;
                        }
                    default:
                        {
                            return this.Cost;
                        }
                }
            }
        }
    }
}
