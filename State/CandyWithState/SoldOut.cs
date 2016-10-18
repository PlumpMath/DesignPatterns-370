using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyWithState
{
    class SoldOut : State
    {
        private GumballMachine gumballMachine;

        public SoldOut(GumballMachine gumballMachine)
        {
            // TODO: Complete member initialization
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurenCrank()
        {
            Console.WriteLine("You turned but there's no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
