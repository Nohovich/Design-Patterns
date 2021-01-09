using Adapter_Pattern.Adapter;
using Adapter_Pattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        /// <summary>
        /// Convert the interface of a class into another interface clients expect.
        /// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces. 
        /// </summary>
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.WriteLine($"the result in Json: {value}");
            Console.ReadKey();
        }
    }
}
