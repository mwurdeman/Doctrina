using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanHighCommand(CeilingFan fan)
        {
            this._ceilingFan = fan;
        }

        public string Execute()
        {
            return this._ceilingFan.High();
        }
    }
}
