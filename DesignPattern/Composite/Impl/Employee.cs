using System;

namespace Composite
{
    public class Employee : Component
    {
        public Employee(string name) : base(name)
        {

        }

        public override void Add(Component c)
        {

        }

        public override void Remove(Component c)
        {

        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}
