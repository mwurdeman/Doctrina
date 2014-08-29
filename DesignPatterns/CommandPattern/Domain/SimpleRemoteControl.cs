using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            this._slot = command;
        }

        public string ButtonWasPressed()
        {
            return this._slot.Execute();
        }
    }
}
