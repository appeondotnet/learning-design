using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 3个孔的插头，源角色——需要适配的类（Adaptee）
    /// </summary>
    public class ThreeHoleTarget
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是三个孔的插头");
        }
    }
}
