using IteratorPattern.Impl;
using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dinnerMenu = new DinnerMenu(1);
            dinnerMenu.AddMenuItem(0, "dinner", "dinner description", 1.25m);

            var panckeHouseMenu = new PancakeHouseMenu();
            panckeHouseMenu.AddMenuItem("pancakeHouse", "pancakeHouse description", 1.1m);

            var caffeeMenu = new CaffeeMenu();
            caffeeMenu.AddMenuItem("caffeeMenu", "caffeeMenu description", 1.5m);

            var menus = new List<IMenu>();

            menus.Add(dinnerMenu);
            menus.Add(panckeHouseMenu);
            menus.Add(caffeeMenu);

            var waitress = new Waitress(menus);

            waitress.Print();

            Console.ReadLine();
        }
    }
}
