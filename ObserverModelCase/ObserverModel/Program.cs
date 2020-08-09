using ObserverModel.Impl.Oberver;
using System;

namespace ObserverModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new WeatherData();

            var currentDisplay = new CurrentConditionDisplay(data);

            data.SetMeasurementsChanged(80, 65, 30.4f);
            data.SetMeasurementsChanged(82, 70, 29.2f);
            data.SetMeasurementsChanged(78, 90, 29.2f);
        }
    }
}
