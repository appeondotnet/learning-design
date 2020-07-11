using BuilderPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class ChineseWall : Wall
    {
        public override void Build()
        {
            Console.WriteLine("Builded a Chinese Style Wall!");
        }
    }
}
