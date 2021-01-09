using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    class Program
    {
        /// <summary>
        /// The State pattern Allow an object to alter its behavior when its internal state changes.
        /// The object will appear to change its class. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Let's cook a steak!
            Steak steak = new Steak("T-Bone");

            // Apply temperature changes that will make the class change state
            steak.AddTemp(120);
            steak.AddTemp(15);
            steak.AddTemp(15);
            steak.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
            steak.RemoveTemp(15);
            steak.AddTemp(20);
            steak.AddTemp(20);
            steak.AddTemp(20);

            Console.ReadKey();
        }
    }
}
