using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class Program
    {
        /// <summary>
        /// The Builder pattern separates the construction of an object from its representation so that the same construction process can create different representations.
        /// The general idea is that the order in which things happen when an object is instantiated will be the same,
        /// but the actual details of those steps change based upon what the concrete implementation is.
        /// </summary>
        static void Main(string[] args)
        {
            // Create deli with sandwich assembly line
            AssemblyLine shop = new AssemblyLine();

            // creating a build of HamAndCheese
            SandwichBuilder builder = new HamAndCheese();

            // passing to this AssemblyLine the build we created
            shop.Assemble(builder);

            // printing the built Sandwich details
            builder.Sandwich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
