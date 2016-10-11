using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl
{
    class RemoteControl
    {
        Command slot;

        public RemoteControl()
        { }
        public void SetCommand(Command command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
