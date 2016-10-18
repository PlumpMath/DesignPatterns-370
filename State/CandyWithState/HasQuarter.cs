using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyWithState
{
    class HasQuarter : State
    {
        private GumballMachine gumballMachine;
        private Random randomWinner = new Random();

        public HasQuarter(GumballMachine gumballMachine)
        {
            // TODO: Complete member initialization
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarter());
        }

        public void TurenCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(0, 10);

            if ((winner == 0) && (gumballMachine.GetCount() > 1))
                gumballMachine.SetState(gumballMachine.GetWinner());
            else
                gumballMachine.SetState(gumballMachine.GetSold());
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
