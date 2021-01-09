using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public class FacebookEnumerator 
    {
        private LinkedList<string> _users;
        private int _position;
        public FacebookEnumerator(LinkedList<string> users)
        {
            this._users = users;
            _position = -1;
        }

        /// <summary>
        /// Gets iterator item at the current position
        /// </summary>
        public string Current
        {
            get
            {
                return _users.ElementAt(_position);
            }
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

        /// <summary>
        /// sets the position value 
        /// </summary>
        public void Reset()
        {
            _position = -1;
        }
    }
}
