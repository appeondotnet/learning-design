using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Waitress
    {
        private readonly IMenuComponent _menu;
        public Waitress(IMenuComponent menu)
        {
            _menu = menu;
        }

        public void Print()
        {
            _menu.Print();
        }
    }
}
