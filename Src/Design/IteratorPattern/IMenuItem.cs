using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface IMenuItem
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
    }
}
