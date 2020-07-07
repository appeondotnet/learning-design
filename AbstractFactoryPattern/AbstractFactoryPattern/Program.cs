using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成现代资源套件
            var modernlFactory = new GameManager(new ModernFactory());

            modernlFactory.Initialization();

            modernlFactory.CreateGameSences();

            //生成古典资源套件
            var classicalFactory = new GameManager(new ClassicalFactory());

            classicalFactory.Initialization();

            classicalFactory.CreateGameSences();
        }
    }
}
