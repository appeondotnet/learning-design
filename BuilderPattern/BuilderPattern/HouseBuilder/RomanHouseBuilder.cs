using BuilderPattern.Component;
using BuilderPattern.Component.ChineseStyle;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class RomanHouseBuilder : Builder
    {
        public override void BuildDoor()
        {
            var door = new RomanDoor();

            door.Build();
        }

        public override void BuildCeiling()
        {
            var ceiling = new RomanCeiling();

            ceiling.Build();
        }

        public override void BuildWall()
        {
            var wall = new RomanWall();

            wall.Build();
        }

        public override void BuildWindow()
        {
            var window = new RomanWindow();

            window.Build();
        }

        public override House GetHouse()
        {
            var house = new RomanHouse();

            return house.CreateHouse();
        }
    }
}
