using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticSingleton
{
    //饿汉模式
    sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private Singleton()
        { }
        public static Singleton GetInstance()
        {
            return _instance;
        }
    }
}
