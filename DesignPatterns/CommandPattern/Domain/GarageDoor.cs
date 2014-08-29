using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GarageDoor
    {
        public string Up()
        {
            return "Garage Door was put up.";
        }

        public string Down()
        {
            return "Garage Door was put down.";
        }

        public string Stop()
        {
            return "The Garage Door was stopped.";
        }

        public string LightOn()
        {
            return "The Garage Door light was turned on.";
        }

        public string LightOff()
        {
            return "The Garage Door light was turned off.";
        }
    }
}
