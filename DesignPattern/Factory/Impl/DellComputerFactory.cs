namespace Factory
{
    public class DellComputerFactory : IComputerFactory
    {
        public IDisplay ProduceDisplay()
        {
            return new DellDisplay();
        }

        public IMainframe ProduceMainframe()
        {
            return new DellMainframe();
        }
    }
}
