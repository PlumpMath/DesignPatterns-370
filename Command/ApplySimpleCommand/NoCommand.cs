using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySimpleCommand
{
    class NoCommand : Command
    {
        public NoCommand()  //在服务员没有被下达命令时默认使用此命令
        { }
        public override void ExcuteCommand()
        {
            Console.WriteLine("没有命令");
        }
    }
}
