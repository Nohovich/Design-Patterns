using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object creation
            Customer c1 = new Customer();
            // Using the method chaining to assign & print data with a single line
            c1.FirstName("vinod").LastName("srivastav").Sex("male").Address("bangalore").Print();
            Console.ReadKey();
        }
    }
}
