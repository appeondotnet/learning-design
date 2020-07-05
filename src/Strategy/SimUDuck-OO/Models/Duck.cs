using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Models
{
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Duck: Quack.");
        }

        public void Swim()
        {
            Console.WriteLine("Duck: Swim.");
        }

        public void Fly()
        {
            Console.WriteLine("Duck: Fly.");
        }

        public abstract void Display();
    }
}
