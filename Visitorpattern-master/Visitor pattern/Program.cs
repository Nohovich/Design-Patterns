using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_pattern
{
    class Program
    {
        /// <summary>
        /// Visitor is a behavioral design pattern that allows adding new behaviors to existing class without altering any existing code.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // creating new employees 
            Employees employees = new Employees();
            // adding staff 
            employees.Attach(new LineCook());
            employees.Attach(new HeadChef());
            employees.Attach(new GeneralManager());

            // Employees are visited, giving them 10% raises and 3 extra paid time off days.
            // passing a new visitor
            employees.Accept(new IncomeVisitor());
            employees.Accept(new PaidTimeOffVisitor());

            Console.ReadKey();
        }
    }
}
