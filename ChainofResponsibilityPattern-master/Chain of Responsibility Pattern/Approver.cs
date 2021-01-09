using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    /// <summary>
    /// The Handler abstract class.
    /// Every class which inherits from this will be responsible for a kind of request for the restaurant.
    /// </summary>
    abstract class Approver
    {
        protected Approver Supervisor;

        /// <summary>
        /// sets the chain of responsibility by adding a supervisor approver for to this approver
        /// </summary>
        /// <param name="supervisor"></param>
        public void SetSupervisor(Approver supervisor)
        {
            this.Supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }

    /// <summary>
    /// A concrete Handler class
    /// </summary>
    class HeadChef : Approver
    {
        /// <summary>
        /// the first method in our chain
        /// it will try to solve the problem,
        /// if it cant it will pass it to the next method in the chain
        /// </summary>
        /// <param name="purchase"></param>
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 1000)
            {
                Console.WriteLine($"{this.GetType().Name} approved purchase request #{purchase.RequestNumber}");
            }
            else if (Supervisor != null)
            {
                // this headChef cant handle this request lets try let our supervisor(next in the chain) handle it
                Supervisor.ProcessRequest(purchase);
            }
        }
    }

    /// <summary>
    /// A concrete Handler class
    /// </summary>
    class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
            {
                Console.WriteLine($"{this.GetType().Name} approved purchase request #{purchase.RequestNumber}");
            }
            else if (Supervisor != null)
            {
                Supervisor.ProcessRequest(purchase);
            }
        }
    }

    /// <summary>
    /// A concrete Handler class
    /// </summary>
    class GeneralManager : Approver
    {
        // last method in the chain the problem if it got here it will be handled here
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
            {
                Console.WriteLine($"{this.GetType().Name} approved purchase request #{purchase.RequestNumber}");
            }
            else
            {
                Console.WriteLine($"Purchase request #{purchase.RequestNumber} requires an executive meeting!");
            }
        }
    }

    /// <summary>
    /// The details of the purchase request.  
    /// </summary>
    class PurchaseOrder
    {
        public int RequestNumber { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        // Constructor
        public PurchaseOrder(int number, double amount, double price, string name)
        {
            RequestNumber = number;
            Amount = amount;
            Price = price;
            Name = name;
            Console.WriteLine($"Purchase request for {name} amount for {price.ToString()} has been submitted.");
        }

       
    }
}
