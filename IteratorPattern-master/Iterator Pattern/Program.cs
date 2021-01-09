using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Program
    {
        /// <summary>
        /// iterator pattern Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create aggregate 
            ISocialNetworking facebook = new Facebook();
            ISocialNetworking twitter = new Twitter();

            // Create iterator
            IIterator facebookIterator = facebook.CreatIterator();
            IIterator twitterIterator = twitter.CreatIterator();

            Console.WriteLine("Facebook");
            PrintUsers(facebookIterator);
            Console.WriteLine("Twitter");
            PrintUsers(twitterIterator);

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iterator"></param>
        public static void PrintUsers(IIterator iterator)
        {
            // sets the iterator index to -1
            iterator.First();

            while(iterator.MoveNext())
            {
                Console.WriteLine(iterator.CurrentItem);
            }
        }
    }
    
}
