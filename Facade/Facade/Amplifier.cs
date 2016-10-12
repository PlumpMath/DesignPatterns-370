using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Amplifier
    {
        private DvdPlayer dvdPlayer;
        private CDPlayer cdPlayer;
        private Tuner tuner;
        internal void On()
        {
            Console.WriteLine("Top-O-Line Amplifier on");
        }

        internal void SetDvd(DvdPlayer dvd)
        {
            this.dvdPlayer = dvd;
            Console.WriteLine("Top-O-Line Amplifier setting DVD player to Top-O-Line DVD Player");
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("Top-O-Line Amplifier surround sound on 5");
        }

        internal void SetVolume(int p)
        {
            Console.WriteLine("Top-O-Line Amplifier setting volume to " + p);
        }

        internal void Off()
        {
            Console.WriteLine("Top-O-Line Amplifier off");
        }
    }
}
