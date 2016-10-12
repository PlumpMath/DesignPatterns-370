using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Projector
    {
        private DvdPlayer dvdPlayer;

        public Projector(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }
        internal void On()
        {
            Console.WriteLine("Top-O-Line Projector on");
        }

        internal void WideScreenMode()
        {
            Console.WriteLine("Top-O-Line Projector in widescreen mode");
        }

        internal void Off()
        {
            Console.WriteLine("Top-O-Line Projector off");
        }
    }
}
