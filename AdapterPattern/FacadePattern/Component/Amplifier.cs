using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Component
{
    internal class Amplifier
    {
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly CdPlayer _cdPlayer;
        private int _volume;

        public Amplifier(Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer)
        {
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Amplifier is on!");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is off!");
        }

        public void SetCd(string Context)
        {
            _cdPlayer.cdContent = Context;
        }

        public void SetDvd(string Context)
        {
            _dvdPlayer.dvdContent = Context;
        }

        public void SetStereoSound()
        {
            _dvdPlayer.SetTwoChannelAudio();
        }

        public void SetSurroundSound()
        {
            _dvdPlayer.SetSurroundAudio();
        }

        public void SetTuner()
        {

        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"volume is {volume} now");
        }
    }
}
