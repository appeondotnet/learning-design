using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    internal class MenuItem : MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegetarian { get; set; }
        public double Price { get; set; }

        public MenuItem(
            string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool IsVegetarian()
        {
            return Vegetarian;
        }

        public override void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine(" " + GetName());

            if (IsVegetarian())
            {
                Console.WriteLine("(v)");
            }

            Console.WriteLine($", {GetPrice()}");
            Console.WriteLine($"  --{GetDescription()}");
        }
    }
}
