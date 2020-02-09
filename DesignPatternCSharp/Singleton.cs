using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp
{
    class Singleton
    {
        private static Singleton instance = null;
        private static object sync = new object();

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (sync)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
        private Singleton()
        {
            Console.WriteLine("Singleton Constructor");
        }
    }
}
