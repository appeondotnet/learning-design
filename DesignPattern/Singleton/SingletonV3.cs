namespace Singleton
{
    public class SingletonV3
    {
        public static SingletonV3 Instance => Nested._instance;

        private SingletonV3()
        {

        }

        private class Nested
        {
            internal static readonly SingletonV3 _instance = new SingletonV3();

            static Nested()
            {

            }
        }
    }
}
