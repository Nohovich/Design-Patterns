using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    /// <summary>
    /// A ConcreteComponent class
    /// a ConcreteComponent will always be the first Component because it don't need to warp another Component
    /// </summary>
    class Espresso : Beverage
    {
        // return itself
        public override string GetDescription()
        {
            return "Espresso/";
        }
        public override int GetPrice()
        {
            return 1;
        }
    }
}
