using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    /// <summary>
    /// composite class
    /// </summary>
    public class CompositeGift : GiftBase, IGiftOperations
    {
        // list of leaf and composite children
        private List<GiftBase> _gifts;

        public CompositeGift(string name, int price)
            : base(name, price)
        {
            _gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            _gifts.Remove(gift);
        }
        

        public override int CalculateTotalPrice() 
        {
            int total = this.Price;

            Console.WriteLine($"{base.Name} with the price {base.Price} contains the following products with prices: ");

            foreach (var gift in _gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }

        public override List<GiftBase> GetChildes()
        {
            return this._gifts;
        }
    }

}
