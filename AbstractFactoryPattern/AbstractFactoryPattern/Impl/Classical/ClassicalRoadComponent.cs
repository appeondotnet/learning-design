using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ClassicalRoadComponent : IRoadComponent
    {
        public void CreateRoadComponent()
        {
            Console.WriteLine("生成了一个古典道路组件！");
        }
    }
}
