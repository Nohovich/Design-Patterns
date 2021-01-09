using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    /// <summary>
    /// The Aggregate defines an interface for creating an Iterator object.
    /// </summary>
    public interface ISocialNetworking
    {
        IIterator CreatIterator();
    }
}
