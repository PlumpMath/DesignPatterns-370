using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyWithState
{
    class GumballMachine
    {
        State soldOut;
        public State GetSoldOut()
        {
            return soldOut;
        }
        State noQuarter;
        public State GetNoQuarter()
        {
            return noQuarter;
        }
        State hasQuarter;
        public State GetHasQuarter()
        {
            return hasQuarter;
        }
        State sold;
        public State GetSold()
        {
            return sold;
        }
        State winner;
        public State GetWinner()
        {
            return winner;
        }

        State state;
        private int count = 0;
        public int GetCount()
        {
            return count;
        }

        public GumballMachine(int count)
        {
            soldOut = new SoldOut(this);
            noQuarter = new NoQuarter(this);
            hasQuarter = new HasQuarter(this);
            sold = new Sold(this);
            winner = new Winner(this);
            this.count = count;
            if (count > 0)
            {
                state = noQuarter;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurenCrank();
            state.Dispense();
        }

        public override string ToString()
        {

            return "count:" + count + "\n" + "state:" + state + "\n";
        }


        internal void SetState(State state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            if (count != 0)
                count--;
        }
    }
}
