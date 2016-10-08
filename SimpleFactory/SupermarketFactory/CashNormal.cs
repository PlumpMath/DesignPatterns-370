using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketFactory
{
    class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
