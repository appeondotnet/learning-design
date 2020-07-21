namespace Singleton
{
    public sealed class SingletonV1
    {
        private static volatile SingletonV1 _instance;

        private static readonly object lockObj = new object();

        public static SingletonV1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonV1();
                        }
                    }
                }

                return _instance;
            }
        }

        private SingletonV1()
        {

        }
    }
}
