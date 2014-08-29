using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StatisticsDisplay: IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            //Display();
        }
        
        public string Display()
        {
            if (_temperature > 90)
            {
                return "Statistics for today: Today was a record temperature at " + _temperature + "F";
            }
            else if (_humidity > 80)
            {
                return "Statistics for today: Today was a record humidity at " + _humidity + "%";
            }
            else if (_pressure > 75)
            {
                return "Statistics for today: Today was a record pressure at " + _pressure;
            }
            else
            {
                return "Statistics for today: No records set";
            }
        }
    }
}
