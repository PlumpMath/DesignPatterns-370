using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu1
{
    class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        //服务员在这里依赖了具体的菜单
        //尽管菜单都实现了统一的接口CreateIterator
        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            Iterator dinerIterator = dinerMenu.CreateIterator();
            Console.WriteLine("Menu\n----\nBreakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLunch");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + ", ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
