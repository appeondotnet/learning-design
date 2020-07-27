using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 我家只有2个孔的插座，也就是适配器模式中的目标角色（Target），这里只能是接口，也是类适配器的限制
    /// </summary>
    public interface ITwoHoleTarget
    {
        void Request();
    }
}
