using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    class Program
    {
        // Summary:  Define an interface for creating an single object!, but let subclasses decide which class to instantiate.
        // Factory Method lets a class defer instantiation to subclasses. 
        static void Main(string[] args)
        {
            // Creating a new Factory Method
            PizzaFactory pizzaFactory = new PizzaFactory();
            // Creating a new pizza using the Factory Method
            Pizza pizza = pizzaFactory.CreatPizza();
            // Chalking if the object isn't null
            if (pizza != null)
            Console.WriteLine(pizza);

            Console.ReadKey();
        }
    }
}
