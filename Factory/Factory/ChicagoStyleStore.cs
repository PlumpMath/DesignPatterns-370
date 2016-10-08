using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class ChicagoStyleStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case "veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
            }
            return pizza;
        }
    }
}
