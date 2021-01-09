using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// and controlling the recrosses of our realSubject.
    /// </summary>
    class BookParserProxy : IBookParser
    {
        // instance of our realSubject
        private BookParser _bookParser = null;
        private string _book;

        public string Book
        {
            get { return _book; }
            set { _book = value; }
        }

        /// <summary>
        /// were passing here the same info that we need to create a new realSubject
        /// </summary>
        /// <param name="book"></param>
        public BookParserProxy(string book)
        {
            this._book = book;
        }

        /// <summary>
        /// this method is controlling the resources of our realSubject
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfPages()
        {
            // checking if instance of our RealSubject is null
            if (this._bookParser == null)
                // if the instance is null the proxy will create a new instance
                this._bookParser = new BookParser(this._book);
            // calling the method of the realSubject from the proxy
            return this._bookParser.GetNumberOfPages();

        }
    }
}
