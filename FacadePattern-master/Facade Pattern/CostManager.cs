using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class CostManager : ICosting
    {

        public float ApplyDiscounts(float price, float discountPercent)
        {
            Console.WriteLine($"A discount of {discountPercent}% has been applied on the product's price of {price}");            
           return price - ((discountPercent / 100) * price);
        }
    }
}
