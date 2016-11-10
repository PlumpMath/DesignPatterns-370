using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuIterator
{
    class Waitress
    {
        MenuComponent allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }
        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator iterator = allMenus.GetEnumerator();
            Console.WriteLine("\n Vegetarian Menu\n----");
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.Current;
                try
                {
                    if (menuComponent.IsVegetarian())
                        menuComponent.Print();
                }
                catch (InvalidOperationException e)
                { }
            }
        }
    }
}
