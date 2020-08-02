using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store_Simple
{
    internal class PizzaFactory
    {
        public static Pizza Create(string type)
        {
            return type switch
            {
                "1" => null,
                "3" => null,
                _ => (Pizza)null,
            };
        }
    }
}
