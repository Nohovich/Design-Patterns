using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    class Program
    {
        /// <summary>
        /// he Template Method pattern defines in what order certain steps should occur,
        /// but can optionally leave the specific details of those steps to be implemented by the concrete class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            // making the bread using the template from the base class
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
    }
}
