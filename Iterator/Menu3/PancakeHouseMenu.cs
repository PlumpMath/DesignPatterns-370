﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu3
{
    class PancakeHouseMenu : Menu
    {
        ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();
            AddItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99);
            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);
            AddItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49);
            AddItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public IEnumerator GetEnumerator()
        {
            return menuItems.GetEnumerator();
        }
    }
}
