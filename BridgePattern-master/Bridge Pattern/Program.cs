using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    /// <summary>
    ///  This pattern is used to separate an abstraction from its implementation so that both can be modified independently.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // creating refined abstraction
            Payment order = new CardPayment();
            // initializing this filed of concrete implementor
            order._IPaymentSystem = new CitiPaymentSystem();

            // calling this method that will invoke the concrete implementor method
            order.MakePayment();

            order._IPaymentSystem = new DIPaymentSystem();
            order.MakePayment();

            order = new BankingPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            Console.ReadKey();
        }
    }
}
