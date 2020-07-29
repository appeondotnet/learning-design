using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface IBeverage
    {
        string Description { get;  }
        decimal Cost { get; }
        BeverageSize Size { get; }
    }
}
