using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    /// <summary>
    /// The ConcreteAggregate implements the Iterator creation interface and returns a ConcreteIterator for that ConcreteAggregate.
    /// </summary>
    public class Twitter : ISocialNetworking
    {
        private string[] _users;
        public Twitter()
        {
            _users = new[] { "Elad", "Tal", "Amir", "Israel" };

        }

        public IIterator CreatIterator()
        {
            return new TwitterIterator(_users);
        }
    }
}
