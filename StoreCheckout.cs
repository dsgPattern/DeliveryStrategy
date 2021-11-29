using System.Linq;

namespace DeliveryStrategy
{
    class StoreCheckout
    {
        private Order _order;
        private IDeliveryCostCalculator _deliveryCostCalculator;

        public StoreCheckout(Order order)
        {
            _order = order;
        }

        public void SetShippingMethod(IDeliveryCostCalculator deliveryCostCalculator)
        {
            _deliveryCostCalculator = deliveryCostCalculator;
        }

        public double GetTotalCost()
        {
            //Order has total cost of products
            var totalProductsCost = _order.Products.Sum(x => x.Price);
            var totalAmount = totalProductsCost + _deliveryCostCalculator.GetShippingCost(_order);
            return totalAmount;
        }
    }
}
