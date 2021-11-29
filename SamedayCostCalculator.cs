using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryStrategy
{
    class SamedayCostCalculator: IDeliveryCostCalculator
    {
        private const double BasePrice = 15;
        private const double MaxFreeWeight = 10;
        private const double PricePerKg = 5;

        public double GetShippingCost(Order order)
        {
            var totalWeight = order.Products.Sum(x => x.Weight);
            var totalCost = BasePrice;
            if (totalWeight > MaxFreeWeight)
            {
                totalCost += (totalWeight - MaxFreeWeight) * PricePerKg;
            }

            return totalCost;
        }
    }
}
