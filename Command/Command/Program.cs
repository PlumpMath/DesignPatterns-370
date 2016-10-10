using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoCommand
{
    class Program
    {
        //不使用命令模式，直接客户端调用,
        //客户端程序与“烤肉串者”紧耦合，尽管简单，但却极为僵化，有许许多多的隐患
        static void Main(string[] args)
        {
            Barbecuer boy = new Barbecuer();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeChickenWing();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeChickenWing();

            Console.ReadKey();
        }
    }
}
