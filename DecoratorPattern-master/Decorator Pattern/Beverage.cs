using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    /// <summary>
    /// The abstract Component class
    /// </summary>
    abstract class Beverage
    {
        public  abstract string GetDescription();
        public abstract int GetPrice();

    }
}
