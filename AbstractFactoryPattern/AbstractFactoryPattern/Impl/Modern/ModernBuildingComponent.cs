using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ModernBuildingComponent : IBuildingComponent
    {
        public void CreateBuildComponent()
        {
            Console.WriteLine("生成了一个现代建筑组件！");
        }
    }
}
