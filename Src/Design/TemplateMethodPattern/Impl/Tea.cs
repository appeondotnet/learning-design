using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add Sugger and milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Tea brew.");
        }
    }
}
