using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class OrderVerificationManager : IOrderVerify
    {

        public bool VerifyShippingAddress(int pincode)
        {
            Console.WriteLine($"The product can be shipped to the pincode {pincode}.");
            return true;
        }
    }
}
