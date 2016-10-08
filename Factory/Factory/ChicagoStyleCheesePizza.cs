using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
