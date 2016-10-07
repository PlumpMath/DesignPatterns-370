using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
     public abstract class BaseDrink : Beverage
    {
         protected Size size;

         public BaseDrink(Size size)
         {
             this.size = size;
         }
         public override double Cost()
         {
             if (this.size == Size.Tall)
                 return .10;
             else if (this.size == Size.Grande)
                 return .15;
             else
                 return .20;
         }
    }
}
