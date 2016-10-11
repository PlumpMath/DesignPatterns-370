using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreButtonRemoteControl
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
