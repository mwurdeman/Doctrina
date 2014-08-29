using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CeilingFan
    {
        private string _speed;

        public CeilingFan()
        {
            this._speed = "Off";
        }

        public string High()
        {
            this._speed = "High";
            return "Ceiling Fan turned on HIGH";
        }

        public string Medium()
        {
            this._speed = "Medium";
            return "Ceiling Fan turned on MEDIUM";
        }

        public string Low()
        {
            this._speed = "Low";
            return "Ceiling Fan turned on LOW";
        }

        public string Off()
        {
            this._speed = "Off";
            return "Ceiling Fan turned OFF";
        }

        public string GetSpeed()
        {
            return this._speed;
        }
    }
}
