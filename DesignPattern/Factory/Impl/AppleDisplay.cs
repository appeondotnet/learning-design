using System;

namespace Factory
{
    public class AppleDisplay : IDisplay
    {
        public void Show()
        {
            Console.WriteLine("苹果显示器显示正常。");
        }
    }
}
