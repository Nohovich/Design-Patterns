using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    /// <summary>
    /// The actual "Facade" class, which hides the complexity of making an Order.
    /// </summary>
    class OnlineShoppingFacade
    {
        // the faced class has all the interface's that it needs to do the work
        IInventory inventory = new InventoryManager();
        IOrderVerify orderVerify = new OrderVerificationManager();
        ICosting costManger = new CostManager();
        IPaymentGateway paymentGateWay = new PaymentGatewayManager();
        ILogistics logistics = new LogisticsManager();

        /// <summary>
        /// making the order
        /// </summary>
        /// <param name="orderDetails"></param>
        public void FinalizeOrder(OrderDetails orderDetails)
        {
            inventory.Update(orderDetails.ProductNo);
            orderVerify.VerifyShippingAddress(orderDetails.PinCode);
            orderDetails.Price = costManger.ApplyDiscounts(orderDetails.Price,orderDetails.DiscountPercent);
            paymentGateWay.VerifyCardDetails(orderDetails.CardNo);
            paymentGateWay.ProcessPayment(orderDetails.CardNo, orderDetails.Price);
            logistics.ShipProduct(orderDetails.ProductName, string.Format($"{orderDetails.AddressLine1}, {orderDetails.AddressLine2} - {orderDetails.PinCode}."));
        }
    }
}
