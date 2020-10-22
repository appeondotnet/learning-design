namespace Builder
{
    public interface IVehicleBuilder
    {
        public Vehicle Vehicle { get; }

        public abstract void BuildFrame();

        public abstract void BuildEngine();

        public abstract void BuildWheels();

        public abstract void BuildDoors();
    }
}
