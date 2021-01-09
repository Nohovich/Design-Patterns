using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Program
    {
        /// <summary>
        /// Provide a unified interface to a set of interfaces in a subsystem.
        /// Façade defines a higher-level interface that makes the subsystem easier to use. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creating the Order/Product details
            OrderDetails orderDetails = new OrderDetails("C# Design Pattern Book", "Simplified book on design patterns in C#", 500,10,"Street No 1","Educational Area", 1212, "4156213754" );
            // Using Facade
            OnlineShoppingFacade facade = new OnlineShoppingFacade();
            // using the faced that to make the life of the client easier
            facade.FinalizeOrder(orderDetails);

            Console.ReadKey();
        }
    }
}
