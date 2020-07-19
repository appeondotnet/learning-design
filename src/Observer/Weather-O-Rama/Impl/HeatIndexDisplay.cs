using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_O_Rama
{
    internal class HeatIndexDisplay : DisplayElement, IObserver
    {
        public HeatIndexDisplay(WeatherData weatherData) : base(weatherData)
        {
            _weatherData.RegisterObserver(this);
        }

        public override void Display()
        {
            Console.WriteLine("Display: HeatIndexDisplay");
        }
    }
}
