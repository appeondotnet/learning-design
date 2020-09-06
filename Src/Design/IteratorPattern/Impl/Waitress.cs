using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class Waitress
    {
        private readonly IList<IMenu> _menus;

        public Waitress(IList<IMenu> menus)
        {
            _menus = menus;
        }

        public void Print()
        {
            foreach (var menu in _menus)
            {
                Console.WriteLine("=====================");

                this.Print(menu.CreateIterator());

                Console.WriteLine("=====================");
            }
        }

        private void Print(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = (IMenuItem)iterator.Next();

                Console.WriteLine($"Name:{menuItem.Name}, Description:{menuItem.Description}, Price:{menuItem.Price}");
            }
        }
    }
}
