using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    class DarkRoast : BaseDrink
    {
       public DarkRoast(Size size) : base(size)
        {
            description = "DarkRoast";
        }

        public override double Cost()
        {
            return .99 + base.Cost();
        }
    }
}
