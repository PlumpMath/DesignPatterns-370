using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyNoState
{
    class GumballMachine
    {
        public const int SOLD_OUT = 0;
        public const int NO_QUARTER = 1;
        public const int HAS_QUARTER = 2;
        public const int SOLD = 3;

        int state = SOLD_OUT;
        int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            switch(state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("You can't insert another quarter");
                    break;
                case NO_QUARTER:
                    state = HAS_QUARTER;
                    Console.WriteLine("You insert a quarter");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You can't insert a quarter, the machine is sold out");
                    break;
                case SOLD:
                    Console.WriteLine("Please wait, We're already giving you a gumball");
                    break;
            }
        }

        public void EjectQuarter()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("Quarter returned");
                    state = NO_QUARTER;
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You haven't inserted a quarter");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
                    break;
                case SOLD:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;
            }
        }

        public void TurnCrank()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("You turned...");
                    state = SOLD;
                    Dispense();
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You turned but there's no quarter");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You turned but there's no gumballs");
                    break;
                case SOLD:
                    Console.WriteLine("Turning twice doesn't get you another gumball!");
                    break;
            }
        }

        public void Dispense()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("No gumball dispensed");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You need to pay first");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("No gumball dispensed");
                    break;
                case SOLD:
                    Console.WriteLine("A gumball comes rolling out the slot");
                    count--;
                    if (count == 0)
                    {
                        Console.WriteLine("Oops, out of gumballs");
                        state = SOLD_OUT;
                    }
                    else
                    {
                        state = NO_QUARTER;
                    }
                    break;
            }
        }

        public override string ToString()
        {

            return "count:" + count + "\n" + "state:" + state + "\n";
        }
    }
}
