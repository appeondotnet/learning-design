using BuilderPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class ChineseDoor : Door
    {
        public override void Build()
        {
            Console.WriteLine("Builded a Chinese Style Door!");
        }
    }
}
