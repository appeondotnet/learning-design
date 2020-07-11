using BuilderPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class GameManager
    {
        public static House CreateHouse(Builder builder)
        {
            builder.BuildDoor();

            builder.BuildWindow();
            builder.BuildWindow();

            builder.BuildCeiling();
            builder.BuildCeiling();
            builder.BuildCeiling();
            builder.BuildCeiling();

            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();

            return builder.GetHouse();
        }
    }
}
