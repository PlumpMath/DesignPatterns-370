using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu2
{
    //此版本改良上一个版本，服务员依赖具体菜单的问题
    //以及，ArrayList已经实现迭代器功能，所以这里去掉
    //服务员的一些代码重复问题仍然存在
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
