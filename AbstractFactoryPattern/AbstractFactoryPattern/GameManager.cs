using AbstractFactoryPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class GameManager
    {
        private readonly FacilitiesFactory _facilitiesFactory;
        private IBuildingComponent _buildingComponent;
        private IJungleComponent _jungleComponent;
        private IRoadComponent _roadComponent;
        private ITunnelComponent _tunnelComponent;


        public GameManager(FacilitiesFactory facilitiesFactory)
        {
            _facilitiesFactory = facilitiesFactory;
        }

        public void Initialization()
        {
            //生成游戏组件，可根据实际情况任意搭配
            _buildingComponent = _facilitiesFactory.GetBuildInstance();

            _jungleComponent = _facilitiesFactory.GetJungleInstance();

            _roadComponent = _facilitiesFactory.GetRoadInstance();

            _tunnelComponent = _facilitiesFactory.GetTunnelInstance();
        }

        public void CreateGameSences()
        {
            _buildingComponent.CreateBuildComponent();

            _jungleComponent.CreateJungleComponent();

            _roadComponent.CreateRoadComponent();

            _tunnelComponent.CreateTunnelComponent();
        }
    }
}
