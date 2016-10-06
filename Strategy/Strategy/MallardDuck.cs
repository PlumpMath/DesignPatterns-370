using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MallardDuck : Duck
    {
        protected override FlyBehavior GetFlyBehavior()
        {
            return new FlyWithWings();
        }

        protected override QuackBehavior GetQuackBehavior()
        {
            return new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
