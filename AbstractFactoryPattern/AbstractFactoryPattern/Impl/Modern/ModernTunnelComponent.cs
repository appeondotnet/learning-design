using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ModernlTunnelComponent : ITunnelComponent
    {
        public void CreateTunnelComponent()
        {
            Console.WriteLine("生成了一个现代隧道组件！");
        }
    }
}
