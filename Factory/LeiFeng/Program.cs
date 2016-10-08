using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeiFeng
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂模式，如果要把大学生换成志愿者，下面三句都要换
            LeiFeng studentA = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentA.BuyRice();

            LeiFeng studentB = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentB.BuyRice();

            LeiFeng studentC = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentC.BuyRice();

            //工厂模式,如果要把大学生换成志愿者，只要换掉工厂即可
            IFactory factory = new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();
        }
    }
}
