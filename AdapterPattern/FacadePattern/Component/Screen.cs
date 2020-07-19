using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Component
{
    internal class Screen
    {
        public void Up()
        {
            Console.WriteLine($"Screen is upping!");
        }

        public void Down()
        {
            Console.WriteLine($"Screen is downing!");
        }
    }
}
