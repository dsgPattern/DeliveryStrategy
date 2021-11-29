using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryStrategy
{
    interface IDeliveryCostCalculator
    {
        double GetShippingCost(Order order);
    }
}
