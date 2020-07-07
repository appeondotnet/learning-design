using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ModernlRoadComponent : IRoadComponent
    {
        public void CreateRoadComponent()
        {
            Console.WriteLine("生成了一个现代道路组件！");
        }
    }
}
