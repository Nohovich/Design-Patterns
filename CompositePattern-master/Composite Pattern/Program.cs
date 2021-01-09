using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    /// <summary>
    ///  Compose objects into tree structures.
    ///  Composite lets clients treat individual leafs and composites uniformly. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // creating a leaf gift
            var phone = new SingleGift("Phone", 256);
            // calculating a leaf
            phone.CalculateTotalPrice();
            phone.CalculateTotalPrice();
            Console.WriteLine();

            //composite gift
            var rootBox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("TruckToy", 289);
            var plainToy = new SingleGift("PlainToy", 587);
            // adding leafs to the composite
            rootBox.Add(truckToy);
            rootBox.Add(plainToy);
            // calculating the branch from our composite
            Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");
            Console.WriteLine($"Total price of this composite present is: {CalculateTotalPriceRecursion(rootBox)}");
            Console.WriteLine();
            var childBox = new CompositeGift("ChildBox", 0);
            var soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            // calculating the branch from our composite
            Console.WriteLine($"Total price of this composite present is: {childBox.CalculateTotalPrice()}");
            Console.WriteLine($"Total price of this composite present is: {CalculateTotalPriceRecursion(childBox)}");
            Console.WriteLine();

            // adding composite to our composite
            rootBox.Add(childBox);

            // calculating the tree branch from our composite
            Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");
            Console.WriteLine($"Total price of this composite present is: {CalculateTotalPriceRecursion(rootBox)}");

            Console.ReadKey();
        }

        /// <summary>
        /// going through all the children using recursion to get the final price
        /// </summary>
        /// <returns></returns>
        public static int CalculateTotalPriceRecursion(GiftBase gift) // help
        {
            int total = gift.Price;
            //if(gift.GetChilds() != null)

            // only if the gift has childes(composite) get inside
            if (gift.GetChildes() != null)
            {
                Console.WriteLine($"{gift.Name} with the price {gift.Price} contains the following products with prices: ");

                // for every child in our composite start this func again 
                foreach (GiftBase oneGift in gift.GetChildes())
                {
                    total += CalculateTotalPriceRecursion(oneGift);
                }
            }
            // if the gift is a leaf
            else
                Console.WriteLine($"{gift.Name} with the price {gift.Price}");

            return total;
        }
    }
}
