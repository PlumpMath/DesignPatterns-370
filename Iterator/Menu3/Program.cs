using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu3
{
    //此版本把所有集合添加到一个集合中解决了服务员代码重复的问题
    class Program
    {
        static void Main(string[] args)
        {
            Menu pancakeHouseMenu = new PancakeHouseMenu();
            Menu dinerMenu = new DinerMenu();
            Menu cafeMenu = new CafeMenu();

            ArrayList menus = new ArrayList();
            menus.Add(pancakeHouseMenu);
            menus.Add(dinerMenu);
            menus.Add(cafeMenu);

            Waitress waitress = new Waitress(menus);
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
