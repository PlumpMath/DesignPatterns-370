using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class DvdPlayer
    {
        private Amplifier amp;
        private string movie;

        public DvdPlayer(Amplifier amp)
        {
            this.amp = amp;
        }
        internal void On()
        {
            Console.WriteLine("Top-O-Line DVD Player on");
        }

        internal void Play(string movie)
        {
            this.movie = movie;
            Console.WriteLine("Top-O-Line DVD Player playing " + movie);
        }

        internal void Stop()
        {
            Console.WriteLine("Top-O-Line DVD Player stopped" + movie);
        }

        internal void Eject()
        {
            Console.WriteLine("Top-O-Line DVD Player eject");
        }

        internal void Off()
        {
            Console.WriteLine("Top-O-Line DVD Player off");
        }
    }
}
