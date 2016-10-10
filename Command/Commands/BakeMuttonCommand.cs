using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        { }
        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
