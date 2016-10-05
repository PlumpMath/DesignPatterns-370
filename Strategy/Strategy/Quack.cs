using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Quack : QuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Quack");
        }
    }
}
