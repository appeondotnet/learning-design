using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("Part X");
        }

        public override void BuilderPartB()
        {
            product.Add("Part Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
