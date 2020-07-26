using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    internal abstract class Beverage
    {
        protected readonly List<Condiment> _condiments;

        public Beverage()
        {
            _condiments = new List<Condiment>();
        }

        protected abstract double Price { get; }

        public virtual string Description { get; } = "Unkonwn Beverage";

        public void AddCondiment(Condiment condiment)
        {
            _condiments.Add(condiment);
        }

        public virtual double Cost()
        {
            return this.Price + _condiments.Sum(x => x.Price);
        }
    }
}
