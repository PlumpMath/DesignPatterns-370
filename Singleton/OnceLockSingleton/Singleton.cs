using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnceLockSingleton
{
    class Singleton
    {
        private static Singleton _instance;
        //程序运行时创建一个静态只读的进程辅助对象
        private static readonly object syncRoot = new object();
        private Singleton()
        { }
        public static Singleton GetInstance()
        {
            lock (syncRoot)
            {
                if (_instance == null)
                    _instance = new Singleton();
            }
            return _instance;
            
        }
    }
}
