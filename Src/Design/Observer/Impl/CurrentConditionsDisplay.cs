using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IElementDisplay
    {
        public CurrentConditionsDisplay(IObservable observable)
        {
            observable.AddOberver(this);
        }
        
        public void Display()
        {
            Console.WriteLine("CurrentConditionsDisplay: {0}", this.Templature);
        }

        public void Update(IObservable observable, params object[] args)
        {
            if (observable is WeatherData weatherData)
            {
                this.Templature = weatherData.Templature;

                this.Display();
            }
        }

        private float Templature { get; set; }
    }
}
