using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Component.ChineseStyle
{
    internal class ChineseCeiling : Ceiling
    {
        public override void Build()
        {
            Console.WriteLine("Builded a Chinese Style Celling!");
        }
    }
}
