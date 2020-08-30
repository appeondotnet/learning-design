using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Caffe : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add Sugger");
        }

        public override void Brew()
        {
            Console.WriteLine("Caffe brew.");
        }
    }
}
