using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var curDisplay = new CurrentConditionsDisplay(weatherData);
            var staDisplay = new StatisticsDisplay(weatherData);
            var forDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(2.1f, 5, 10.1f);

            Console.ReadKey();
        }
    }
}
