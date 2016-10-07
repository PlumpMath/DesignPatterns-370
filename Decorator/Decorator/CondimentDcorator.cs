using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    public abstract class CondimentDcorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDcorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + description;
        }
    }
}
