namespace Builder
{
    public class MotorcycleBuilder : IVehicleBuilder
    {
        private readonly Vehicle _vehicle;

        public Vehicle Vehicle => _vehicle;

        public MotorcycleBuilder()
        {
            _vehicle = new Vehicle("Motorcycle");
        }

        public void BuildFrame()
        {
            _vehicle["frame"] = "MotorCycle Frame";
        }

        public void BuildEngine()
        {
            _vehicle["engine"] = "500 cc";
        }

        public void BuildWheels()
        {
            _vehicle["wheels"] = "2";
        }

        public void BuildDoors()
        {
            _vehicle["doors"] = "0";
        }
    }
}
