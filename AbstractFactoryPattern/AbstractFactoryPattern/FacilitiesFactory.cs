using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class FacilitiesFactory
    {
        public abstract IBuildingComponent GetBuildInstance();

        public abstract IJungleComponent GetJungleInstance();

        public abstract IRoadComponent GetRoadInstance();

        public abstract ITunnelComponent GetTunnelInstance();

    }
}
