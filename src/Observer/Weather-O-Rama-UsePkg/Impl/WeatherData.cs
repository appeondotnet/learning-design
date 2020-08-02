using NXHub.Extensions.Observer;

namespace Weather_O_Rama_UsePkg
{
    internal class WeatherData : Observable<Data>
    {
        internal void SetMeasurements(float temperature, float humidity, float pressure)
        {
            var data = new Data
            {
                Temperature = temperature,
                Humidity = humidity,
                Pressure = pressure,
            };

            this.NotifyObservers(data);
        }
    }
}
