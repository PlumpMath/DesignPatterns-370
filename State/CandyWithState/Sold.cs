using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyWithState
{
    class Sold : State
    {
        private GumballMachine gumballMachine;

        public Sold(GumballMachine gumballMachine)
        {
            // TODO: Complete member initialization
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, We're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurenCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarter());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                gumballMachine.SetState(gumballMachine.GetSoldOut());
            }
        }
    }
}
