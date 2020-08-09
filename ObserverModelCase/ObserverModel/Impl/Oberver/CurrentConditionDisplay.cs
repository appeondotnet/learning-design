using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverModel.Impl.Oberver
{
    public class CurrentConditionDisplay : IOberver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degress and{_humidity}% humidity");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            this.Display();
        }
    }
}
