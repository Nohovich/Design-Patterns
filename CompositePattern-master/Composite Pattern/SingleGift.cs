using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    /// <summary>
    /// Leaf class
    /// </summary>
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, int price)
            : base(name, price)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{base.Name} with the price {base.Price}");

            return base.Price;
        }

        public override List<GiftBase> GetChildes()
        {
            return null;
        }
    }

}
