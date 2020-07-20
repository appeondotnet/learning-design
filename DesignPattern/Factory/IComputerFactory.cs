namespace Factory
{
    public interface IComputerFactory
    {
        IDisplay ProduceDisplay();

        IMainframe ProduceMainframe();
    }
}
