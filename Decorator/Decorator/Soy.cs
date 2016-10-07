using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    class Soy: CondimentDcorator
    {
       public Soy(Beverage beverage): base(beverage)
        {
            description = "Soy";
        }
        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}
