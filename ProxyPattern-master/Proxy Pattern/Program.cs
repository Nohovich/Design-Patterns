using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class Program
    {
        /// <summary>
        /// The Proxy pattern provides a surrogate to a class that we don't want users to talk directly.
        /// The Proxy will take control on the resource of the RealSubject.
        /// The Proxy object can be used in the same manner as its containing object.
        /// </summary>
        static void Main(string[] args)
        {
            // crating our proxy
            BookParserProxy bookParserProxy = new BookParserProxy("Badolina");
            // calling a method from our proxy that if needed will make a new instance of our RealSubject
            Console.WriteLine(bookParserProxy.GetNumberOfPages());
            Console.ReadKey();

        }
    }
}
