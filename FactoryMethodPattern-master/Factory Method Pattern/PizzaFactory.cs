using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    /// <summary>
    ///   concrete factory method
    ///   creates a new kind of pizza
    /// </summary>
    class PizzaFactory : IPizzaFactory
    {
        // field pizza name
        private string _pizzaName;

        // public property for pizza name
        public string PizaName
        {
            get { return _pizzaName; }
            set { _pizzaName = value; }
        }
        // field size
        private string _size;

        // public property for size
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <summary>
        /// this func returns a new pizza by the name and size
        /// </summary>
        /// <returns></returns>
        public Pizza CreatPizza()
        {
            Console.WriteLine("Enter the pizza you want");
            // enter one of those names margarita, Hawaiian, Greek
            _pizzaName = Console.ReadLine();

            Console.WriteLine("Enter the size you want");
            // enter piza size S, M, l, xl
            _size = Console.ReadLine();
            switch (_pizzaName.ToLower())
            {
                case "margarita":
                    return new Margarita(_size);
                case "hawaiian":
                    return new Hawaiian(_size);
                case "greek":
                    return new Greek(_size);
                default:
                    return null;
            }
        }
    }
}
