using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Observer
{
    public class StatisticsDisplay : IObserver, IElementDisplay
    {
        public StatisticsDisplay()
        { 
        }

        public StatisticsDisplay(IObservable observable)
        {
            observable.AddOberver(this);
        }

        public void Display()
        {
            Console.WriteLine("StatisticsDisplay templature: {0}, pressure: {1}, humidity: {2}", this.Templature, this.Presure, this.Humidity );
        }

        public void Update(IObservable observable, params object[] args)
        {
            if (observable is WeatherData weatherData)
            {
                this.Templature = weatherData.Templature;
                this.Presure = weatherData.Presure;
                this.Humidity = weatherData.Humdity;

                this.Display();
            }
        }

        private float Templature { get; set; }

        private float Presure { get; set; }
        
        public float Humidity { get; set; }
    }
}
