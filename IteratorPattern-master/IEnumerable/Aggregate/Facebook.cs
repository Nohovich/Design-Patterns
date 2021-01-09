using IEnumerable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class Facebook
    {
        private LinkedList<string> _users;
        public Facebook()
        {
            _users = new LinkedList<string>();
            _users.AddLast("David");
            _users.AddLast("Ori");
            _users.AddLast("Asaf");
            _users.AddLast("Matan");
            _users.AddLast("Ron");
        }

        /// <summary>
        /// this method is returning IEnumerable of string(_users)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> facebook()
        {
            for (int i = 0; i < _users.Count; i++)
            {
                yield return _users.ElementAt(i);
            }
        }

        /// <summary>
        /// this method lets us do a  for each on the class itself
        /// the method must be called GetEnumerator
        /// the method will return a Enumerator,
        /// in the Enumerator class we wrote the method we need
        /// </summary>
        /// <returns></returns>
        public FacebookEnumerator GetEnumerator()
        {
            return new FacebookEnumerator(_users);
        }

    }
}
