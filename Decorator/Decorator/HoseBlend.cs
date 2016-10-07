using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    public class HoseBlend : BaseDrink
    {
        public HoseBlend(Size size): base(size)
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89 + base.Cost();
        }
    }
}
