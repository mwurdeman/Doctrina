using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Singleton
    {
        private static volatile Singleton _uniqueInstance;
        private static object syncRoot = new Object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                lock (syncRoot)
                {
                    if (_uniqueInstance == null)
                        _uniqueInstance = new Singleton();
                }
            }

            return _uniqueInstance;
        }
    }
}
