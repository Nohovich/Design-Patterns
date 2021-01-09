using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    /// <summary>
    /// A ConcreteDecorator. This class will impart "responsibilities"
    /// ConcreteDecorator can't be the first Component because it needs to warp another Component
    /// </summary>
    class Caramel : AddOnDecorator
    {
        // passing a Component that this ConcreteDecorator can warp
        public Caramel(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        /// <summary>
        /// gets the description of the this object and all the other objects are warped by this object
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            // calling the same method from the object that this object is warping,
            // getting the answer and adding this object filed to the answer
            return this.Beverage.GetDescription() + "caramel/";
        }

        /// <summary>
        /// gets the price of the this object and all the other objects are warped by this object
        /// </summary>
        /// <returns></returns>
        public override int GetPrice()
        {
            // calling the same method from the object that this object is warping,
            // getting the answer and adding this object filed to the answer
            return this.Beverage.GetPrice() + 2;
        }
    }
}
