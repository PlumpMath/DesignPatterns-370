using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl
{
    class GarageDoorOpenCommand : Command
    {
        GarageDoor door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }
        public void Execute()
        {
            door.Up();
        }
    }
}
