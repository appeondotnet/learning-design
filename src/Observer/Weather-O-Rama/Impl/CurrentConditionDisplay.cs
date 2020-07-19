using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_O_Rama
{
    internal class CurrentConditionDisplay : DisplayElement, IObserver
    {
        public CurrentConditionDisplay(WeatherData weatherData) : base(weatherData)
        {
            _weatherData.RegisterObserver(this);
        }

        public override void Display()
        {
            Console.WriteLine(
                $"Current conditions: {_temperature}" +
                $"F degrees and {_humidity}% humidity");
        }
    }
}
