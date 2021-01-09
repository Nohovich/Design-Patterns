using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class Program
    {
        /// <summary>
        /// In the Memento pattern, we need to capture and externalize an object's state so that the object can be
        /// restored to that state at a later time.  A good example of this is undo/redo operations.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Here's a new supplier for our restaurant
            FoodSupplier foodSupplier = new FoodSupplier();
            foodSupplier.Name = "David Noho";
            foodSupplier.Phone = "050679485";

            // Let's store that entry in our database.
            SupplierMemory supplierMemory = new SupplierMemory();

            // using the caretaker to save our memento data
            supplierMemory.Memento = foodSupplier.SaveMemento();

            // Continue changing originator
            foodSupplier.Address = "Tel Aviv";

            // Crap, gotta undo that entry, I entered the wrong address
            // using the caretaker to retrieve our memento saved data
            foodSupplier.RestoreMemento(supplierMemory.Memento);

            Console.ReadKey();
        }
    }
}
