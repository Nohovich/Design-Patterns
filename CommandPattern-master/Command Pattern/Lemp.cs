using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    /// <summary>
    /// The Receiver knows how to execute the operations associated with the action of the request.
    /// </summary>
    class Lemp
    {
        /// <summary>
        /// after getting execute command from the ConcreteCommand,
        /// this Receiver is executing the action called
        /// </summary>
        public void On()
        {
            Console.WriteLine("Turning the light on");
        }
        public void Off()
        {
            Console.WriteLine("Turning the light off");
        }
    }
}
