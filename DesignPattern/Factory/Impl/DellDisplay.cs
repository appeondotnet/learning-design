using System;

namespace Factory
{
    public class DellDisplay : IDisplay
    {
        public void Show()
        {
            Console.WriteLine("戴尔显示器显示正常。");
        }
    }
}
