using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyWithState
{
    class NoQuarter : State
    {
        GumballMachine gumballMachine;
        public void InsertQuarter()
        {
            Console.WriteLine("You insert a quarter");
            gumballMachine.SetState(gumballMachine.GetHasQuarter());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurenCrank()
        {
            Console.WriteLine("You turned but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public NoQuarter(GumballMachine gumballMachine)
        {
            // TODO: Complete member initialization
            this.gumballMachine = gumballMachine;
        }
    }
}
