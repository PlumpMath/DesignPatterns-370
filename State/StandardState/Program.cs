using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardState
{
    //与策略模式相似，但是目的不同
    //策略模式是根据用户的需要转换不同的策略，
    //使用哪一种策略由用户决定
    //状态模式是根据状态来改变相应的行为
    //而且状态模式在子类中需要持有调用它的类的实例来改变状态，具有一定的耦合性
    //而策略模式则不需要
    class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadKey();
        }
    }
}
