using BuilderPattern.Component;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            House chineseHouse = GameManager.CreateHouse(new ChineseHouseBuilder());

            House romanHouse = GameManager.CreateHouse(new RomanHouseBuilder());
        }
    }
}
