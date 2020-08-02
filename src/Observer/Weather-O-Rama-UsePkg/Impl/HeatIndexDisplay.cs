using System;

namespace Weather_O_Rama_UsePkg
{
    internal class HeatIndexDisplay : DisplayElement
    {
        public HeatIndexDisplay(WeatherData weatherData) : base(weatherData)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Display: HeatIndexDisplay");
        }
    }
}
