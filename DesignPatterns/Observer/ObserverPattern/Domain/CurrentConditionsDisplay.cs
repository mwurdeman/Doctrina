using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            //Display();
        }

        public string Display()
        {
            return "The current conditions are " + _temperature +"F with " + _humidity + "% humidity and pressure at " + _pressure;
        }
    }
}
