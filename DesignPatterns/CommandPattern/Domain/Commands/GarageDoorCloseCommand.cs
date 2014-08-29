using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }

        public string Execute()
        {
            return this._garageDoor.Down();
        }
    }
}
