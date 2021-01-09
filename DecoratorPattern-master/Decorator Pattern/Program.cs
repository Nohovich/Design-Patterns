using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        /// <summary>
        /// The Decorator design pattern seeks to add new functionality to an existing object without changing that object's definition.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // creating a new ConcreteComponent
            Decaf decaf = new Decaf();
            // creating a new ConcreteDecorator that wraps our ConcreteComponent
            Soy soy = new Soy(decaf);
            // creating a new ConcreteDecorator that wraps our ConcreteDecorator
            Soy soy1 = new Soy(soy);
            // creating a new ConcreteDecorator that wraps our ConcreteDecorator
            Caramel caramel = new Caramel(soy1);

            // going through all the objects that are warping our ConcreteComponent
            Console.WriteLine(caramel.GetDescription());
            Console.WriteLine(caramel.GetPrice().ToString());


            Console.ReadKey();
        }
    }
}
