using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySimpleCommand
{
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        { }
        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
