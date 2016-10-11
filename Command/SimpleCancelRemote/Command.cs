using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCancelRemote
{
    interface Command
    {
        void Execute();
        void Undo();
    }
}
