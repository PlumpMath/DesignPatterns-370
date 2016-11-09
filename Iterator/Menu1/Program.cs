using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu1
{
    //此版本的服务员依赖了具体的菜单
    //而且ArrayList本身就有迭代器功能并不需要手动添加迭代器
    //在服务员遍历时还是需要一些重复代码，例如获取迭代器，打印各迭代器的每一项
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
