using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Decorator
{
    internal abstract class CondimentDecorator : Beverage
    {
        public override string Description => "Unkonwn Condiment";
    }
}
