using Iterator_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Facebook facebook = new Facebook();
            facebook.facebook();
            foreach(string str in facebook)
            {
                Console.WriteLine(str);
            }

            Twitter twitter = new Twitter();
            foreach(string str in twitter)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
        
    }
}
