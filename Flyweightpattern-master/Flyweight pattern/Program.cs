using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
    class Program
    {
        /// <summary>
        /// The Flyweight design pattern is used to create lots of small, related objects without invoking a lot of overhead work in doing so, thereby improving performance and maintainability.
        /// The idea is that each Flyweight object has two pieces:
        /// 1) The intrinsic state, which is stored within the Flyweight object itself,
        /// 2)  The extrinsic state, which is stored or calculated by other components.
        /// </summary>
        static void Main(string[] args)
        {
            // Build a slider order using patron's input
            Console.WriteLine("Please enter your slider order (use characters B, V, Q with no spaces):");
            // getting the info from the user
            var order = Console.ReadLine();
            // converting the info from the user to CharArray
            char[] chars = order.ToCharArray();
            // creating a new Flyweight Factory class
            SliderFactory factory = new SliderFactory();
            // number of order
            int orderNumber = 0;

            //Get the slider from the factory
            foreach (char c in chars)
            {
                orderNumber++;
                // using the Flyweight Factory class
                Slider character = factory.GetSlider(c);
                // display the slider
                character.Display(orderNumber);
            }

            Console.ReadKey();
        }
    }
}
