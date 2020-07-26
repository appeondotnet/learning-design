using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Impl
{
    internal class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("添加茶叶需要放的配料！");
        }

        public override void Brew()
        {
            Console.WriteLine("进行冲泡茶叶的步骤！");
        }
    }
}
