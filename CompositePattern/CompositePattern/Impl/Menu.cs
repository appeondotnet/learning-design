using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace CompositePattern
{
    internal class Menu : MenuComponent
    {
        public readonly List<MenuComponent> _menuComponents;
        public string Name { get; set; }
        public string Description { get; set; }

        public Menu(string name, string description)
        {
            this.Name = name;
            this.Description = description;

            _menuComponents = new List<MenuComponent>();
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override void Print()
        {
            Console.WriteLine("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("----------------------");

            foreach (var item in _menuComponents)
            {
                item.Print();
            }
        }
    }
}
