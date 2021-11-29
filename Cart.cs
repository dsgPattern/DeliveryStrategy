using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryStrategy
{
    class Cart
    {
        private Order _order;
        private IDeliveryCostCalculator _deliveryCostCalculator;

        public Cart(Order order)
        {
            _order = order;
        }

        public void SetShippingMethod(IDeliveryCostCalculator deliveryCostCalculator)
        {
            _deliveryCostCalculator = deliveryCostCalculator;
        }

        public double GetTotalCost()
        {
            //Order has total cost produselor
            var totalProductsCost = 100;
            var totalAmount = totalProductsCost + _deliveryCostCalculator.GetShippingCost(_order);
            return totalAmount;
        }
    }
}
