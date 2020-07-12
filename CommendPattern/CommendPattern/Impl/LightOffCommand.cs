using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }

        public string GetName()
        {
            return _light.GetName();
        }
    }
}
