using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCancelRemote
{
    class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Close");
        }
    }
}
