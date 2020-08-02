using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    internal class Waitress
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private readonly DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;

            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();

            IIterator dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("菜单\n--------\n早餐吃什么\n");

            PrintMenu(pancakeIterator);

            Console.WriteLine("中午吃啥");
        }

        public void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();

                Console.WriteLine($"菜名: { menuItem.GetName()},");

                Console.WriteLine($"价格: {menuItem.GetPrice()}元");

                Console.WriteLine($"描述信息: {menuItem.GetDescription()}");
            }
        }
    }
}
