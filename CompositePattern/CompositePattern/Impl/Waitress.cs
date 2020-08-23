using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    internal class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent menu)
        {
            _allMenus = menu;
        }

        public void Print()
        {
            _allMenus.Print();
        }
    }
}
