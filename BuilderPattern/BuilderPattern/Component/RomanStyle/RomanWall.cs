using BuilderPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class RomanWall : Wall
    {
        public override void Build()
        {
            Console.WriteLine("Builded a Roman Style Wall!");
        }
    }
}
