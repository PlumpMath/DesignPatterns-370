using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
