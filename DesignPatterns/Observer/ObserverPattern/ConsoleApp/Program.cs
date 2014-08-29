using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(85, 75, 30);
            Console.WriteLine(currentDisplay.Display());
            Console.WriteLine(statDisplay.Display());
            Console.WriteLine(forecastDisplay.Display());

            weatherData.SetMeasurements(86, 90, 65);
            Console.WriteLine(currentDisplay.Display());
            Console.WriteLine(statDisplay.Display());
            Console.WriteLine(forecastDisplay.Display());

            Console.WriteLine("Please press <<ENTER>> to exit the program");
            Console.ReadLine();
        }
    }
}
