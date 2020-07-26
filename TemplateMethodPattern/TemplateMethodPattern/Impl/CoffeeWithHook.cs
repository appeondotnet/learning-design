using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TemplateMethodPattern.Impl
{
    internal class CoffeeWithHook : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("添加咖啡需要放的配料！");
        }

        public override void Brew()
        {
            Console.WriteLine("进行咖啡的冲泡步骤！");
        }

        public override bool CustomerWantsCondiments()
        {
            return GetUserInput();
        }

        public bool GetUserInput()
        {
            Console.WriteLine("你需要添加其他的配料吗？(Y/N)");

            var input = Console.ReadLine();

            if (input.ToUpper().Trim() == "Y")
            {
                return true;
            }
            else if (input.ToUpper().Trim() == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("输入错误，默认不加配料！");
                return false;
            }
        }
    }
}
