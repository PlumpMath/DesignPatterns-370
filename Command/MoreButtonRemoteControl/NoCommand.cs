using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreButtonRemoteControl
{
    class NoCommand : Command
    {
        public NoCommand()
        { }

        public void Execute()
        {
            Console.WriteLine("no command");
        }
    }
}
