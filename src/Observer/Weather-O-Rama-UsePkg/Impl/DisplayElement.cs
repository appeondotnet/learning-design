using System;
using NXHub.Extensions.Observer;

namespace Weather_O_Rama_UsePkg
{
    internal abstract class DisplayElement : IObserver<Data>
    {
        protected Data _data;

        public DisplayElement(Observable<Data> weatherData)
        {
            weatherData.Subscribe(this);
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Data value)
        {
            _data = value;

            this.Display();
        }

        public abstract void Display();
    }
}
