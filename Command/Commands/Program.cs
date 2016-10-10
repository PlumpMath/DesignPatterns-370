using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer cook = new Barbecuer();
            Command bakeMutton1 = new BakeMuttonCommand(cook);
            Command bakeMutton2 = new BakeMuttonCommand(cook);
            Command bakeChickenWing = new BakeChickenWingCommand(cook);
            Waiter girl = new Waiter();

            girl.SetOrder(bakeMutton1);
            girl.SetOrder(bakeMutton2);
            girl.SetOrder(bakeChickenWing);
            girl.Notify();

            Console.ReadKey();
        }
    }
}
