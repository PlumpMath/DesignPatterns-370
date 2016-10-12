using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks
{
    class Program
    {
        //没有使用模板方法模式，没有面向对象
        //有大量重复代码
        static void Main(string[] args)
        {
            Coffe coffee = new Coffe();
            Tea tea = new Tea();
            coffee.PrepareRecipe();
            tea.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
