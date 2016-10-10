using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySimpleCommand
{
    abstract class Command
    {
        protected Barbecuer receiver;

        public Command() { }    //为创建没有命令的命令
        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        public abstract void ExcuteCommand();
    }
}
