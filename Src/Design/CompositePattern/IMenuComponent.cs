using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    interface IMenuComponent
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }

        void AddMenu(IMenuComponent menu);
        void RemoveMenu(IMenuComponent menu);
        void Print();
        IIterator CreateIterator();
    }
}
