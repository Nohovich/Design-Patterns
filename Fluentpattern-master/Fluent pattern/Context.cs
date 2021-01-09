using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_pattern
{
    // Defines the data context
    class Context
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
    }

    class Customer
    {
        private Context _context = new Context(); // Initializes the context

        // set the value for properties
        public Customer FirstName(string firstName)
        {
            _context.FirstName = firstName;
            return this;
        }

        public Customer LastName(string lastName)
        {
            _context.LastName = lastName;
            return this;
        }

        public Customer Sex(string sex)
        {
            _context.Sex = sex;
            return this;
        }

        public Customer Address(string address)
        {
            _context.Address = address;
            return this;
        }

        // Prints the data to console
        public void Print()
        {
            Console.WriteLine("First name: {0} \nLast name: {1} \nSex: {2} \nAddress: {3}", _context.FirstName, _context.LastName, _context.Sex, _context.Address);
        }
    }
}
