using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 适配器类，接口要放在类的后面，在此无法适配更多的对象，这是类适配器的不足
    /// </summary>
    public class ThreeToTwoAdapter : ThreeHoleTarget, ITwoHoleTarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
