using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class ChineseWindow : Window
    {
        public override void Build()
        {
            Console.WriteLine("Builded a Chinese Style Window!");
        }
    }
}
