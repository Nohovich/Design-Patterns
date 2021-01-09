using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    interface IOrderVerify
    {
        bool VerifyShippingAddress(int pincode);
    }
}
