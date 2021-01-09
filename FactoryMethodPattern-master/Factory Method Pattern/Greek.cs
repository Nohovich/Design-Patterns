using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    /// <summary>
    /// concrete pizza
    /// </summary>
    class Greek : Pizza
    {
       
        private string _size;
        public override string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Greek(string Size)
        {
            this._size = Size;
        }

        public override string ToString()
        {
            return ($"{base.ToString()} {_size}");
        }
    }
}
