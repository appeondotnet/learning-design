using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Impl
{
    internal class SingletonInstance
    {
        private static volatile SingletonInstance _instance;
        private readonly static object _lock = new object();

        private SingletonInstance()
        {

        }

        public SingletonInstance GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonInstance();
                    }
                }
            }

            return _instance;
        }

    }
}
