using FacadePattern.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        public HomeTheaterFacade()
        {
            this.CdPlayer = new CdPlayer();
            this.DvdPlayer = new DvdPlayer();
            this.PopcomPopper = new PopcomPopper();
            this.Projector = new Projector();
            this.Screen = new Screen();
            this.TheaterLights = new TheaterLights();
            this.Tuner = new Tuner();
        }

        public HomeTheaterFacade(
            CdPlayer cdPlayer, 
            DvdPlayer dvdPlayer,
            PopcomPopper popcomPopper, 
            Projector projector, 
            Screen screen, 
            TheaterLights theaterLights, 
            Tuner tuner)
        {
            this.CdPlayer = CdPlayer;
            this.DvdPlayer = dvdPlayer;
            this.PopcomPopper = popcomPopper;
            this.Projector = projector;
            this.Screen = screen;
            this.TheaterLights = theaterLights;
            this.Tuner = tuner;
        }

        private CdPlayer CdPlayer { get; }
        private DvdPlayer DvdPlayer { get; }
        private PopcomPopper PopcomPopper { get; }
        private Projector Projector { get; }
        private Screen Screen { get; }
        private TheaterLights TheaterLights { get; }
        private Tuner Tuner { get; }

        public void On()
        {
            this.CdPlayer.On();
            this.DvdPlayer.On();
            this.Screen.Up();
            this.TheaterLights.On();
            this.PopcomPopper.On();
            this.Tuner.On();
        }

        public void Off()
        {
            this.CdPlayer.Off();
            this.DvdPlayer.Off();
            this.Screen.Down();
            this.TheaterLights.Off();
            this.PopcomPopper.Off();
            this.Tuner.Off();
        }
    }
}
