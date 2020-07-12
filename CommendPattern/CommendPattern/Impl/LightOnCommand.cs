using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            _light.On();
        }

        public string GetName()
        {
            return _light.GetName();
        }
    }
}
