namespace Choc_O_Holic
{
    internal class ChocolateBoiler3
    {
        private static ChocolateBoiler3 _instance;
        private static readonly object _lock = new object();

        private ChocolateBoiler3(object arg)
        {
        }

        public static ChocolateBoiler3 GetInstance(object arg)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    return _instance ??= new ChocolateBoiler3(arg);
                }
            }

            return _instance;
        }
    }
}
