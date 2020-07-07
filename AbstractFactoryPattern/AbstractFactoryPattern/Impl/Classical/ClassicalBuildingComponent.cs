using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ClassicalBuildingComponent : IBuildingComponent
    {
        public void CreateBuildComponent()
        {
            Console.WriteLine("生成了一个古典建筑组件！");
        }
    }
}
