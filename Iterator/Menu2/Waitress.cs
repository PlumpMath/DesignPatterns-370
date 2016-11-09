using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu2
{
    class Waitress
    {
        Menu pancakeHouseMenu;
        Menu dinerMenu;
        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            //不可避免地重复创建迭代器并使用PrintMenu(pancakeIterator);
            IEnumerator pancakeIterator = pancakeHouseMenu.GetEnumerator();
            IEnumerator dinerIterator = dinerMenu.GetEnumerator();
            Console.WriteLine("Menu\n----\nBreakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLunch");
            PrintMenu(dinerIterator);
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
