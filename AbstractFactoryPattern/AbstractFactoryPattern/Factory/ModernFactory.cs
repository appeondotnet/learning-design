using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ModernFactory : FacilitiesFactory
    {
        public override IBuildingComponent GetBuildInstance()
        {
            return new ModernBuildingComponent();
        }

        public override IJungleComponent GetJungleInstance()
        {
            return new ModernlJungleComponent();
        }

        public override IRoadComponent GetRoadInstance()
        {
            return new ModernlRoadComponent();
        }

        public override ITunnelComponent GetTunnelInstance()
        {
            return new ModernlTunnelComponent();
        }
    }
}
