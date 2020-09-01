using System;
using System.Collections.Generic;

namespace Composite
{
    public class Department : Component
    {
        private readonly List<Component> _components;

        public Department(string name) : base(name)
        {
            _components = new List<Component>();
        }

        public override void Add(Component c)
        {
            _components.Add(c);
        }

        public override void Remove(Component c)
        {
            _components.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (Component item in _components)
            {
                //这里用到了递归的思想
                item.Display(depth + 4);
            }
        }
    }
}
