using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    /// <summary>
    /// The abstract Decorator class.  
    /// </summary>
    abstract class AddOnDecorator : Beverage
    {

       public Beverage Beverage;
        
    }
}
