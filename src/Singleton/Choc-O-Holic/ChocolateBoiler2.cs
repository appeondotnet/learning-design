namespace Choc_O_Holic
{
    internal class ChocolateBoiler2
    {
        private static ChocolateBoiler2 _instance;
        private static readonly object _lock = new object();

        private ChocolateBoiler2(object arg)
        {
        }

        public static ChocolateBoiler2 GetInstance(object arg)
        {
            lock (_lock)
            {
                return _instance ??= new ChocolateBoiler2(arg);
            }
        }
    }
}
