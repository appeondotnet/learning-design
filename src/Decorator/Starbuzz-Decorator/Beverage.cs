using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Decorator
{
    internal abstract class Beverage
    {
        public virtual string Description { get; } = "Unkonwn Beverage";

        public abstract double Cost();
    }
}
