using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySimpleCommand
{
    class Waiter
    {
        private Command command = new NoCommand();

        public void SetOrder(Command command)
        {
            this.command = command;
        }

        public void Notify()
        {
            //使用了默认命令后就不需要判断命令是否为空之后才执行命令
            command.ExcuteCommand();
        }
    }
}
