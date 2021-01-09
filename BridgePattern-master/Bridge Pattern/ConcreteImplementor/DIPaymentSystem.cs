using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class DIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"Using DIBank gateway for {paymentSystem}");
        }
    }
}
