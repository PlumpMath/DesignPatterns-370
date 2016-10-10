using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySimpleCommand
{ 
    class Program
    {
        //应用简单的命令模式只能一次请求一个任务并执行，也不具备撤销功能
        //通常一次下达几个命令，然后再某一时刻全部执行
        //菜单是下达好几个菜，然后统一执行的
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            Barbecuer cook = new Barbecuer();
            Command bakeMutton1 = new BakeMuttonCommand(cook);
            Command bakeMutton2 = new BakeMuttonCommand(cook);
            Command bakeChickenWing = new BakeChickenWingCommand(cook);

            waiter.SetOrder(bakeMutton1);
            waiter.Notify();
            waiter.SetOrder(bakeMutton2);
            waiter.Notify();
            waiter.SetOrder(bakeChickenWing);
            waiter.Notify();

            Console.ReadKey();
        }
    }
}
