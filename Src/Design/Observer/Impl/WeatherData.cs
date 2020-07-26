using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class WeatherData : IObservable
    {
        private readonly IList<IObserver> _observrs;
        private bool _changed;

        public WeatherData()
        {
            _observrs = new List<IObserver>();
        }

        public float Templature { get; private set; }

        public float Presure { get; private set; }

        public float Humdity { get; private set; }

        public void AddOberver(IObserver observer)
        {
            if (!_observrs.Contains(observer))
            {
                _observrs.Add(observer);
            }
        }

        public void NotifyObservers()
        {
            if (!_changed)
            {
                return;
            }
            
            foreach (var observer in _observrs)
            {
                observer.Update(this, null);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observrs.Contains(observer))
            {
                _observrs.Remove(observer);
            }
        }

        public void SetChanged()
        {
            _changed = true;
        }

        public void SetMeasurements(float templature, float presure, float humidity)
        {
            this.Templature = templature;
            this.Presure = presure;
            this.Humdity = humidity;

            this.MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            this.SetChanged();

            this.NotifyObservers();
        }
    }
}
