using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommand
{
    class Program
    {
        //标准的命令模式框架
        //客户端类似于顾客
        static void Main(string[] args)
        {
            Invoker Waiter = new Invoker();
            Receiver Cook = new Receiver();
            Command Paper = new ConcreteCommand(Cook);
            Waiter.SetCommand(Paper);
            Waiter.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
