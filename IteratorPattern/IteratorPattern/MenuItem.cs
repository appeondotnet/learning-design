using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    internal class MenuItem
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this._name = name;
            this._description = description;
            this._vegetarian = vegetarian;
            this._price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public bool IsVegetarian()
        {
            return _vegetarian;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
