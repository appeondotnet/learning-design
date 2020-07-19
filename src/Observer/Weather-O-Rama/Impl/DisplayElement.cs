using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_O_Rama
{
    internal abstract class DisplayElement
    {
        protected float _temperature;
        protected float _humidity;
        protected float _pressure;
        protected readonly WeatherData _weatherData;

        public DisplayElement(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public virtual void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;

            this.Display();
        }

        public abstract void Display();
    }
}
