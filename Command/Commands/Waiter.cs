using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Waiter
    {
        private List<Command> commands = new List<Command>();

        public void SetOrder(Command command)
        {
            if (command.ToString() == "Commands.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤");
            }
            else
            {
                commands.Add(command);
                Console.WriteLine("增加订单：" + command + "时间：" + DateTime .Now);
            }
        }

        public void Notify()
        {
            foreach(Command cmd in commands)
            {
                cmd.ExcuteCommand();
            }
        }
    }
}
