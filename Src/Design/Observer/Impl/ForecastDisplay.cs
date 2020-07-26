using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ForecastDisplay : IObserver, IElementDisplay
    {
        public ForecastDisplay()
        { 
        }

        public ForecastDisplay(IObservable observable)
        {
            observable.AddOberver(this);
        }

        private float Presure { get; set; }

        public void Display()
        { 
            Console.WriteLine("ForecastDisplay presure: {0}", this.Presure);
        }


        public void Update(IObservable observable, params object[] args)
        {
            if (observable is WeatherData weatherData)
            {
                this.Presure = weatherData.Presure;

                this.Display();
            }
        }
    }
}
