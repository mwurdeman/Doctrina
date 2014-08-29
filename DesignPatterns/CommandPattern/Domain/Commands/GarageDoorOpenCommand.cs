using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }

        string ICommand.Execute()
        {
            return _garageDoor.Up();
        }
    }
}
