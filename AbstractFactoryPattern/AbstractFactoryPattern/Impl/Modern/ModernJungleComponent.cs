using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ModernlJungleComponent : IJungleComponent
    {
        public void CreateJungleComponent()
        {
            Console.WriteLine("生成了一个现代丛林组件！");
        }
    }
}
