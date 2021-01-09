using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public class Twitter
    {
        private string[] _users;
        public Twitter()
        {
            _users = new[] { "Elad", "Tal", "Amir", "Israel" };

        }

        /// <summary>
        /// this method is returning IEnumerable of string(_users)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> twitter()
        {
            for (int i = 0; i < _users.Length; i++)
            {
                yield return _users[i];
            }
        }

        /// <summary>
        /// this method lets us do a  for each on the class itself
        /// the method must be called GetEnumerator
        /// the method will return a Enumerator,
        /// in the Enumerator class we wrote the method we need
        /// </summary>
        /// <returns></returns>
        public TwitterEnumerator GetEnumerator()
        {
            return new TwitterEnumerator(_users);
        }
        
    }
}
