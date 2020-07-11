using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Component
{
    internal abstract class House
    {
        public abstract House CreateHouse();
    }
}
