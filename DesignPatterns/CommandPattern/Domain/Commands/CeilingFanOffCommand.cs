using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            this._ceilingFan = fan;
        }

        public string Execute()
        {
            return this._ceilingFan.Off();
        }
    }
}
