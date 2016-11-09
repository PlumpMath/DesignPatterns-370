using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTicket
{
    class Program
    {
        //大话设计模式中的例子
        //这个例子代码比较丑陋
        //但是这个例子是从实现不同的迭代方式的角度看的
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交内部员工";
            a[5] = "小偷";

            Iterator i1 = a.CreateIterator();
            Iterator i = new ConcreIteratorDesc(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 请买车票！", i.CurrentItem());
                i.Next();
            }

            Console.ReadKey();
        }
    }
}
