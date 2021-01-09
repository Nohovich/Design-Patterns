using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    /// <summary>
    /// The ConcreteIterator implements the Iterator interface and keeps track of its current position within the Aggregate.
    /// </summary>
    public class FacebookIterator : IIterator
    {
        private LinkedList<string> _users;
        private int _position;
        public FacebookIterator(LinkedList<string> users)
        {
            this._users = users;
            _position = -1;
        }
        /// <summary>
        /// Gets iterator item at the current position
        /// </summary>
        public string CurrentItem
        {
            get
            {
                return _users.ElementAt(_position);
            }
        }

        /// <summary>
        /// sets the position value 
        /// </summary>
        public void First()
        {
            _position = -1;
        }

        /// <summary>
        /// moves the position by one and checking if there an next item
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _position++;
            return _position < _users.Count;
        }

    }
}
