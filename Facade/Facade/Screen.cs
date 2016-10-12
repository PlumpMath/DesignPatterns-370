using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Theater Screen going down");
        }

        internal void Up()
        {
            Console.WriteLine("Theater Screen going up");
        }
    }
}
