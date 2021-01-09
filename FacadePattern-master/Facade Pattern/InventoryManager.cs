using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class InventoryManager : IInventory
    {
        public void Update(int productId)
        {
            Console.WriteLine($"Product# {productId} is subtracted from the store's inventory.");
       }
    }
}
