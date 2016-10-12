using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popcorn Popper on");
        }

        internal void Pop()
        {
            Console.WriteLine("Popcorn Popper popping popcorn!");
        }

        internal void Off()
        {
            Console.WriteLine("Popcorn Popper off");
        }
    }
}
