using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SignletonPattern
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler _cholocateBoiler;
        private static object _lockObj = new object();

        public ChocolateBoiler()
        {
            this.IsBoiler = false;
            this.IsEmpty = true;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_cholocateBoiler == null)
            {
                lock (_lockObj)
                {
                    if (_cholocateBoiler == null)
                    {
                        _cholocateBoiler = new ChocolateBoiler();
                    }
                }
            }

            return _cholocateBoiler;
        }

        public bool IsEmpty { get; private set; }
        public bool IsBoiler { get; private set; }

        public void Fill()
        {
            if (this.IsEmpty)
            {
                this.IsEmpty = false;
            }
        }

        public void Drain()
        {
            if (!this.IsEmpty && !this.IsBoiler)
            {
                this.IsEmpty = true;
                this.IsBoiler = false;
            }
        }

        public void Boil()
        {
            if (!this.IsEmpty && !this.IsBoiler)
            {
                this.IsBoiler = true;
            }
        }
    }
}
