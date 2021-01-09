using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    /// <summary>
    /// Ensure a class has only one instance and provide a global point of access to it. 
    /// </summary>
    class Singleton
    {
        // our static instance starting null
        private static Singleton _instance;

        // key to make the singleton thread safe
        private static object _key = new object();

        // private constructor making it impossible to create a new singleton from out of the class
        private Singleton()
        {

        }

        /// <summary>
        /// this func in the only one that have access to creating a new singleton only if our _instance is still null
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            // checking if our _instance is still null
            if (_instance == null)
            {
                // only one thread can enter this each time making sure only one _instance of our class will be created
                lock (_key)
                {
                    // checking if our _instance is still null
                    if (_instance == null)
                    {
                        // if it is null create _instance for the first and last time
                        _instance = new Singleton();
                    }
                }
            }
            // if not null return _instance that all can use for communicate with the class
            return _instance;
        }
    }
}
