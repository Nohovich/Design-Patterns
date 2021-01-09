using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    /// <summary>
    /// The Abstract Factory class, which defines methods for creating abstract objects.
    /// </summary>
    abstract class AccommodationFactory
    {
        public abstract Room CreateRoom();
        public abstract Facility CreateFacility();
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    abstract class Room { }

    /// <summary>
    /// A concrete product
    /// </summary>
    class Suite : Room { }

    /// <summary>
    /// A concrete product
    /// </summary>
    class PresidentialSuite  : Room { }

    /// <summary>
    /// An abstract product.
    /// </summary>
    abstract class Facility { }

    /// <summary>
    /// A concrete product
    /// </summary>
    class bathtub : Facility { }

    /// <summary>
    /// A concrete product
    /// </summary>
    class Jacuzzi : Facility { }


    /// <summary>
    /// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    /// </summary>
    class WealthyRoomFactory : AccommodationFactory
    {
        public override Room CreateRoom()
        {
            return new PresidentialSuite();
        }

        public override Facility CreateFacility()
        {
            return new Jacuzzi();
        }
    }

   
    /// <summary>
    /// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    /// </summary>
    class WorkingClassRoomFactory : AccommodationFactory
    {
        public override Room CreateRoom()
        {
            return new Suite();
        }

        public override Facility CreateFacility()
        {
            return new bathtub();
        }
    }
}
