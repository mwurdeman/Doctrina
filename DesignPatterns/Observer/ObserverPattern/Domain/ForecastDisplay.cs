using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ForecastDisplay: IObserver, IDisplayElement
    {
        private double _humidity;
        private double _temperature;
        private ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this._temperature = temperature;
            //Display();
        }

        public string Display()
        {
             if (_temperature > 85)
             {
                 return "Forecast Conditions: Hot afternoon on the way";
             }
             else
             {
                 return "Forecast Conditions: Cooling down nicely for the evening";
             }
        }
    }
}
