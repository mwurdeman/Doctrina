using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for(int i = 0; i < _offCommands.Length; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public string OnButtonWasPushed(int slot)
        {
            return _onCommands[slot].Execute();
        }

        public string OffButtonWasPushed(int slot)
        {
            return _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------Remote Contol------");
            for(int i = 0; i < this._onCommands.Length; i++)
            {
                string displayLine = String.Format("[Slot {0}] {1}   {2}", i.ToString(), _onCommands[i].GetType(), _offCommands[i].GetType());
                sb.AppendLine(displayLine);
            }

            return sb.ToString();
        }
    }
}
