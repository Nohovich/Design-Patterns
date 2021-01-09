using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    /// <summary>
    /// The realSubject class which the Proxy can stand in for
    /// </summary>
    class BookParser : IBookParser
    {
        public string Book { get; private set; }
        public BookParser(string book)
        {
            this.Book = book;
        }

        public int GetNumberOfPages()
        {
            return Book.Length;
        }
    }
}
