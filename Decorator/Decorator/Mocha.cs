using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    class Mocha : CondimentDcorator
    {
       public Mocha(Beverage beverage) : base(beverage)
        {
            description = "Mocha";
        }
        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
