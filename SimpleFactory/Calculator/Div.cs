using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Div : Operation
    {
        public override double Calculate(double numberA, double numberB)
        {
            return numberA / numberB;
        }
    }
}
