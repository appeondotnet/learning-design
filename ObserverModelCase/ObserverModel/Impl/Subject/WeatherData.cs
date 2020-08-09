using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverModel
{
    public class WeatherData : ISubject
    {
        private List<IOberver> _obervers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _obervers = new List<IOberver>();
        }

        public void NotifyObserver()
        {
            foreach (var item in _obervers)
            {
                item.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IOberver oberver)
        {
            _obervers.Add(oberver);
        }

        public void RemoveObserver(IOberver oberver)
        {
            _obervers.Remove(oberver);
        }

        public void MeasurementsChanged()
        {
            this.NotifyObserver();
        }

        public void SetMeasurementsChanged(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            this.MeasurementsChanged();
        }
    }
}
