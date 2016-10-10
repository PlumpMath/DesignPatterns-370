using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommand
{
    class ConcreteCommand : Command //类似于具体的菜单
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        { }
        public override void Execute()
        {
            receiver.Action();
        }
    }
}
