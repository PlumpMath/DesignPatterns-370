using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCancelRemote
{
    class NoCommand : Command
    {
        public NoCommand()
        { }

        public void Execute()
        {
            Console.WriteLine("no command");
        }


        public void Undo()
        {
            Console.WriteLine("no command");
        }
    }
}
