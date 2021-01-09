using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    /// <summary>
    ///  The Iterator defines an interface for accessing an Aggregate object and traversing elements within that Aggregate.
    /// </summary>
    public interface IIterator
    {
        void First();
        bool MoveNext();
        string CurrentItem { get; }
    }
}
