using BuilderPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal abstract class Builder
    {
        public abstract void BuildDoor();

        public abstract void BuildWall();

        public abstract void BuildWindow();

        public abstract void BuildCeiling();

        public abstract House GetHouse();
    }
}
