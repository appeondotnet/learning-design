namespace Builder
{
    public class CarBuilder : IVehicleBuilder
    {
        private readonly Vehicle _vehicle;

        public Vehicle Vehicle => _vehicle;

        public CarBuilder()
        {
            _vehicle = new Vehicle("Car");
        }

        public void BuildFrame()
        {
            _vehicle["frame"] = "Car Frame";
        }

        public void BuildEngine()
        {
            _vehicle["engine"] = "2500 cc";
        }

        public void BuildWheels()
        {
            _vehicle["wheels"] = "4";
        }

        public void BuildDoors()
        {
            _vehicle["doors"] = "4";
        }
    }
}
