using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StereoOnCommand : ICommand
    {
        private Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }

        public string Execute()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this._stereo.On());
            sb.AppendLine(this._stereo.SetCD());
            sb.AppendLine(this._stereo.SetVolume(11));
            return sb.ToString();
        }
    }
}
