using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            IVehicleBuilder builder = new CarBuilder();

            shop.Construct(builder);

            builder.Vehicle.Show();

            builder = new MotorcycleBuilder();

            shop.Construct(builder);

            builder.Vehicle.Show();

            Console.Read();
        }
    }
}
