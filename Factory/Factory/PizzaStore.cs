﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Back();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}
