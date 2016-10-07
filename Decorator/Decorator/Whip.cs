using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    class Whip: CondimentDcorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
            description = "Whip";
        }
        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
