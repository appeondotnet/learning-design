using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Component.ChineseStyle
{
    internal class RomanCeiling : Ceiling
    {
        public override void Build()
        {
            Console.WriteLine("Builded a Roman Style Celling!");
        }
    }
}
