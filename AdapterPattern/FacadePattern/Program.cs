using FacadePattern.Component;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuner = new Tuner();
            var dvdPlayer = new DvdPlayer();
            var cdPlayer = new CdPlayer();
            var amplifier = new Amplifier(tuner, dvdPlayer, cdPlayer);
            var projector = new Projector();
            var lights = new TheaterLights();
            var screen = new Screen();
            var popper = new PopcornPopper();

            HomeTeaterFacade homeTeater = new HomeTeaterFacade(
                amplifier,
                tuner,
                dvdPlayer,
                cdPlayer,
                projector,
                lights,
                screen,
                popper);

            homeTeater.WatchMovie("变形金刚4");
            homeTeater.EndMovie();
        }
    }
}
