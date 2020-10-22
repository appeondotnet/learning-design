namespace Builder
{
    public class Shop
    {
        public void Construct(IVehicleBuilder builder)
        {
            builder.BuildFrame();

            builder.BuildEngine();

            builder.BuildWheels();

            builder.BuildDoors();
        }
    }
}
