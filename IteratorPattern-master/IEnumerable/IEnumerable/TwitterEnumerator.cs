using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public class TwitterEnumerator
    {
        private string[] _users;
        private int _position;
        public TwitterEnumerator(string[] users)
        {
            this._users = users;
            _position = 0;
        }

        /// <summary>
        /// Gets iterator item at the current position
        /// </summary>
        public string Current
        {
            get
            {
                return _users[_position];
            }
        }

        /// <summary>
        /// moves the position by one and checking if there an next item
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _position++;
            return _position < _users.Length;
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
