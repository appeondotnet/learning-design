using System.Runtime.CompilerServices;

namespace Choc_O_Holic
{
    internal class ChocolateBoiler1
    {
        private static ChocolateBoiler1 _instance;

        private ChocolateBoiler1(object arg)
        {
        }

        [MethodImpl(MethodImplOptions = MethodImplOptions.Synchronized)]
        public static ChocolateBoiler1 GetInstance(object arg)
        {
            return _instance ??= new ChocolateBoiler1(arg);
        }
    }
}
