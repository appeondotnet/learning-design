using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Impl
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen Up");
        }

        public void Down()
        {
            Console.WriteLine("Screen Down");
        }
    }
}
