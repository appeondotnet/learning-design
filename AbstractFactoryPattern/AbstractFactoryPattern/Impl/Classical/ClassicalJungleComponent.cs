using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ClassicalJungleComponent : IJungleComponent
    {
        public void CreateJungleComponent()
        {
            Console.WriteLine("生成了一个古典丛林组件！");
        }
    }
}
