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
    public class Facebook : ISocialNetworking
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

        public IIterator CreatIterator()
        {
            return new FacebookIterator(_users);
        }
    }
}
