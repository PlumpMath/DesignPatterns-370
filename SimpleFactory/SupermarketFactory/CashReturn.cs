using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketFactory
{
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn(double moneyCondition, double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }
        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            return result;
        }
    }
}
