using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    public class Espresso : BaseDrink
    {
        public Espresso(Size size) : base(size)
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99 + base.Cost();
        }
    }
}
