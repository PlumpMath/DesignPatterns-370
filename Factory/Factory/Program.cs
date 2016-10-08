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
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStyleStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.Name);
            Console.WriteLine();

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.Name);
        }
    }
}
