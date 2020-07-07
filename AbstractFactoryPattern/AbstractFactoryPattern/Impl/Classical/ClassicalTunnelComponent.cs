using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ClassicalTunnelComponent : ITunnelComponent
    {
        public void CreateTunnelComponent()
        {
            Console.WriteLine("生成了一个古典隧道组件！");
        }
    }
}
