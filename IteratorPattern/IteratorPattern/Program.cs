using System;
using System.Collections;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenuList = new ArrayList();

            pancakeHouseMenuList.Add(new MenuItem("香蕉", "一只贪吃的胖猫", false, 3000));

            pancakeHouseMenuList.Add(new MenuItem("香蕉的小老弟", "香蕉的毛绒玩具", false, 15));

            pancakeHouseMenuList.Add(new MenuItem("香蕉的猫粮", "淘宝9.9包邮买来的猫粮", false, 9.9));

            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu(pancakeHouseMenuList);

            var dinerMenuList = new MenuItem[DinerMenu.MAX_ITEMS];

            dinerMenuList[1] = new MenuItem("精品鲱鱼罐头", "香蕉最爱的零食", false, 10);

            dinerMenuList[2] = new MenuItem("膨润土猫砂", "无毒安全可食用", false, 29.9);

            DinerMenu dinerMenu = new DinerMenu(dinerMenuList);

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
        }
    }
}
