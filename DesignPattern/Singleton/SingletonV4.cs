using System;

namespace Singleton
{
    public class SingletonV4
    {
        private static readonly Lazy<SingletonV4> _instance = new Lazy<SingletonV4>(() => new SingletonV4());

        public static SingletonV4 Instance => _instance.Value;

        private SingletonV4()
        {

        }
    }
}
