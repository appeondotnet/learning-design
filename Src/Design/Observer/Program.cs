using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            weatherData.AddOberver(new CurrentConditionsDisplay());
            weatherData.AddOberver(new StatisticsDisplay());
            weatherData.AddOberver(new ForecastDisplay());

            weatherData.SetMeasurements(2.1f, 5, 10.1f);
            
            Console.ReadKey();
        }
    }
}
