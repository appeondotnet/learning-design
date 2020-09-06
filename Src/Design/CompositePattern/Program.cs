using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var cafeMenu1 = new MenuItem("cafeMenu1", "cafeMenu1 description", 1.2m);
            var cafeMenu2 = new MenuItem("cafeMenu2", "cafeMenu2 description", 1.21m);

            var cafeMenu = new MenuComposite();

            cafeMenu.AddMenu(cafeMenu1);
            cafeMenu.AddMenu(cafeMenu2);

            var dinnerMenu = new MenuComposite();

            var dinnerMenu1 = new MenuComposite("dinnerMenu tian pin", "description dinnerMenu tian pin");

            var tp1 = new MenuItem("tp1", "description tp1", 12.1m);
            var tp2 = new MenuItem("tp2", "description tp2", 12.12m);

            dinnerMenu1.AddMenu(tp1);
            dinnerMenu1.AddMenu(tp2);

            var dinnerMenu2 = new MenuItem("dinnerMenu2", "description dinnerMenu2", 2.1m);

            dinnerMenu.AddMenu(dinnerMenu1);
            dinnerMenu.AddMenu(dinnerMenu2);

            var menu = new MenuComposite();

            menu.AddMenu(dinnerMenu);
            menu.AddMenu(cafeMenu);

            var waitress = new Waitress(menu);

            waitress.Print();

            Console.ReadKey();
        }
    }
}
