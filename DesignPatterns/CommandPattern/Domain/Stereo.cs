using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Stereo
    {
        public string On()
        {
            return "Stereo turned ON";
        }

        public string Off()
        {
            return "Stereo turned OFF";
        }

        public string SetCD()
        {
            return "Stereo set to CD";
        }

        public string SetDVD()
        {
            return "Stereo set to DVD";
        }

        public string SetRadio()
        {
            return "Stereo set to RADIO";
        }

        public string SetVolume(int volumeLevel)
        {
            return "Stereo Volume Set to " + volumeLevel.ToString();
        }
    }
}
