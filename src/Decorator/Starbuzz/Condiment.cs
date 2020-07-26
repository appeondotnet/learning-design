using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public abstract class Condiment
    {
        public abstract double Price { get; }

        public virtual string Discription { get; } = "Unkonwn Condiment";
    }
}
