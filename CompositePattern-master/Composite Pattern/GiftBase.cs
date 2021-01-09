using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    /// <summary>
    /// Component abstract class
    /// </summary>
    public abstract class GiftBase
    {
        protected int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public GiftBase(string name, int price)
        {
            this._name = name;
            this._price = price;
        }
        public abstract int CalculateTotalPrice();

        public abstract List<GiftBase> GetChildes();

    }

}
