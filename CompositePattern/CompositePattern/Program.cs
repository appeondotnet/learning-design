using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMenu = new Menu("包子店", "早餐");

            var secondMenu = new Menu("汉堡王", "中餐");

            var thirdMenu = new Menu("米其林轮胎", "晚餐");

            var thirdChildMenu = new Menu("米其林三星餐厅", "晚餐");

            var allMenus = new Menu("总菜单", "包含所有的菜单在内");

            firstMenu.Add(new MenuItem(
                "灌汤包",
                "里面有汤的包子",
                false,
                9.99));

            secondMenu.Add(new MenuItem(
                "素食汉堡",
                "没有肉的汉堡",
                true,
                18.78));

            thirdChildMenu.Add(new MenuItem(
                "盘子沾酱",
                "摆盘拍照套装",
                false,
                 998));

            thirdMenu.Add(thirdChildMenu);

            allMenus.Add(firstMenu);

            allMenus.Add(secondMenu);

            allMenus.Add(thirdMenu);

            //加入菜单项
            var waitress = new Waitress(allMenus);

            waitress.Print();

        }
    }
}
