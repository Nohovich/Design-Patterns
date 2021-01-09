using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class BankingPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Banking Payment");
        }
    }
}
