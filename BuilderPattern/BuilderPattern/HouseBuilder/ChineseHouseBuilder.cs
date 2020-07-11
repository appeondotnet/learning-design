using BuilderPattern.Component;
using BuilderPattern.Component.ChineseStyle;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class ChineseHouseBuilder : Builder
    {
        public override void BuildDoor()
        {
            var door = new ChineseDoor();

            door.Build();
        }

        public override void BuildCeiling()
        {
            var ceiling = new ChineseCeiling();

            ceiling.Build();
        }

        public override void BuildWall()
        {
            var wall = new ChineseWall();

            wall.Build();
        }

        public override void BuildWindow()
        {
            var window = new ChineseWindow();

            window.Build();
        }

        public override House GetHouse()
        {
            var house = new ChineseHouse();

            return house.CreateHouse();
        }
    }
}
