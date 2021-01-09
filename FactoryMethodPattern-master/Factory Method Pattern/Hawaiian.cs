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
    class Hawaiian : Pizza
    {
        private string _size;
        public override string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Hawaiian(string Size)
        {
            this._size = Size;
        }
        public override string ToString()
        {
            return ($"{base.ToString()} {_size}");
        }
    }
}
