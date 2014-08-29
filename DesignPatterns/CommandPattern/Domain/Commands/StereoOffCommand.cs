using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StereoOffCommand : ICommand
    {
        private Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }

        public string Execute()
        {
            return this._stereo.Off();
        }
    }
}
