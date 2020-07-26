using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Impl
{
    internal class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("添加咖啡需要放的配料！");
        }

        public override void Brew()
        {
            Console.WriteLine("进行咖啡的冲泡步骤！");
        }
    }
}
