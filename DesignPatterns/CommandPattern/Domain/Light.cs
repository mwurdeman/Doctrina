using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Light
    {
        private string _name;

        public Light(string name)
        {
            this._name = name;
        }

        public string On()
        {
            return "Light was turned on.";
        }

        public string Off()
        {
            return "Light was turned off.";
        }
    }
}
