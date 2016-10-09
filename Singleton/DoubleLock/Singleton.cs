using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLock
{
    class Singleton
    {
        private static Singleton _instance;
        private static readonly object syncRoot = new object();

        private Singleton()
        { }
        internal static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock(syncRoot)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }
            return _instance;

        }
    }
}
