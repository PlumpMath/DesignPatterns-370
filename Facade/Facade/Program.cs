using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        //外观模式设计基于子系统设计简单的接口方便客户端调用子系统的功能
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            DvdPlayer dvd = new DvdPlayer(amp);
            CDPlayer cd = new CDPlayer(amp);
            Projector projector = new Projector(dvd);
            Tuner tuner = new Tuner(amp);
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            PopcornPopper popper = new PopcornPopper();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);
            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();

        }
    }
}
