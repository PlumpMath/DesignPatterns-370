using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class TheaterLights
    {
        internal void Dim(int percent)
        {
            Console.WriteLine("Theater Ceiling Lights dimming to " + percent + "%");
        }

        internal void On()
        {
            Console.WriteLine("Theater Ceiling Lights on");
        }
    }
}
