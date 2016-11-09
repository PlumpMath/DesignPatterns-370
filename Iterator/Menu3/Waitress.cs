using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu3
{
    class Waitress
    {
        ArrayList menus;
        public Waitress(ArrayList menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            IEnumerator menuIterator = menus.GetEnumerator();
            while(menuIterator.MoveNext())
            {
                Console.WriteLine("\n----");
                Menu menu = (Menu)menuIterator.Current;
                PrintMenu(menu.GetEnumerator());
            }
        }

        private void PrintMenu(IEnumerator iterator)
        {
            while(iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Current;
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + ", ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
