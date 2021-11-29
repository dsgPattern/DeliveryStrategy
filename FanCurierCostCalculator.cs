using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryStrategy
{
    class FanCurierCostCalculator: IDeliveryCostCalculator
    {
        private const double MaxFreeWeight = 10;
        private const double ExtraKgCost = 2;
        private const double MaxFreeDistance = 200;
        private const double ExtraKmCost = 100.566576575;
        private const double BasePrice = 14;

        public double GetShippingCost(Order order)
        {
            var totalWeight = order.Products.Sum(x => x.Weight);
            double totalCost = BasePrice;

            //if (totalWeight > MaxFreeWeight)
            //{
            //    totalCost += (totalWeight - MaxFreeWeight) * ExtraKgCost;
            //}

            if (order.DistanceToDestination > MaxFreeDistance)
            {
                totalCost += (order.DistanceToDestination - MaxFreeDistance) * ExtraKmCost;
            }

            return totalCost;
        }
    }
}
