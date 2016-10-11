﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreButtonRemoteControl
{
    class GarageDoorCloseCommand : Command
    {
        private GarageDoor door;

        public GarageDoorCloseCommand(GarageDoor door)
        {
            this.door = door;
        }
        public void Execute()
        {
            door.Down();
        }
    }
}
