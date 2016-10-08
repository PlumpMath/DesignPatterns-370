using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
     abstract class Pizza
    {
        public string Name { get; protected set; }
        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }
        public virtual void Back()
        {
            Console.WriteLine("Bake for 25 minute at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

    }
}
