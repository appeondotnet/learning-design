using FacadePattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class HomeTeaterFacade
    {
        private readonly Amplifier _amp;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly CdPlayer _cdPlayer;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;
        private readonly Screen _screen;
        private readonly PopcornPopper _popper;

        public HomeTeaterFacade(Amplifier amp,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            Projector projector,
            TheaterLights lights,
            Screen screen,
            PopcornPopper popper)
        {
            _amp = amp;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("准备开始观看电影...");
            _popper.On();
            _popper.Pop();
            _lights.Dim();
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(movie);
            _dvdPlayer.On();
            _dvdPlayer.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("关闭电影，准备工作结束中...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvdPlayer.Pause();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}
