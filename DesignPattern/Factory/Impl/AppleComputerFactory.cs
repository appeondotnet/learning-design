namespace Factory
{
    public class AppleComputerFactory : IComputerFactory
    {
        public IDisplay ProduceDisplay()
        {
            return new AppleDisplay();
        }

        public IMainframe ProduceMainframe()
        {
            return new AppleMainframe();
        }
    }
}
