using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);
            Pizza pizza = pizzaStore.OrderPizza("cheese");
        }
    }
}
