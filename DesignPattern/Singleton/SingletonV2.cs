namespace Singleton
{
    public class SingletonV2
    {
        // 因为下面声明了静态构造函数，所以在第一次访问该类之前，new SingletonV2()语句不会执行
        private static readonly SingletonV2 _instance = new SingletonV2();

        public static SingletonV2 Instance => _instance;

        private SingletonV2()
        {

        }

        // 声明静态构造函数就是为了删除IL里的BeforeFieldInit标记
        static SingletonV2()
        {

        }
    }
}
