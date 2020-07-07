using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ClassicalFactory : FacilitiesFactory
    {
        public override IBuildingComponent GetBuildInstance()
        {
            return new ClassicalBuildingComponent();
        }

        public override IJungleComponent GetJungleInstance()
        {
            return new ClassicalJungleComponent();
        }

        public override IRoadComponent GetRoadInstance()
        {
            return new ClassicalRoadComponent();
        }

        public override ITunnelComponent GetTunnelInstance()
        {
            return new ClassicalTunnelComponent();
        }
    }
}
