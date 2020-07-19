using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    internal class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;
        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Fly()
        {
            _duck.Fly();
        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}
