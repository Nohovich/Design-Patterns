using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        /// <summary>
        /// The Abstract Factory pattern provides an interface for creating related families of objects
        /// without needing to specify the concrete implementations.
        /// This pattern is critical for ideas like Dependency Injection.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (A)wealthy or (C)WorkingClass ?");
            char input = Console.ReadKey().KeyChar;
            AccommodationFactory factory;
            // the AccommodationFactory(Abstract Factory),
            // will create the objects we need at running time.
            // the objects that will be create will Depend on the info that the user sends 
            switch (input)
            {
                case 'A':
                    factory = new WealthyRoomFactory();
                    break;

                case 'C':
                    factory = new WorkingClassRoomFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            var room = factory.CreateRoom();
            var facility = factory.CreateFacility();

            Console.WriteLine($"\nroom: {room.GetType().Name}");
            Console.WriteLine($"facility: {facility.GetType().Name}");

            Console.ReadKey();
        }
    }
}
