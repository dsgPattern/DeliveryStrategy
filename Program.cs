using System;

namespace DeliveryStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.AddProduct(new Product{Name = "Smartphone", Weight = 0.3});
            order.AddProduct(new Product { Name = "Dishwasher", Weight = 10 });
            order.DistanceToDestination = 210;

            var fanCurierCost = new FanCurierCostCalculator().GetShippingCost(order);
            var samedayCost = new SamedayCostCalculator().GetShippingCost(order);
            Console.WriteLine(fanCurierCost);
            Console.WriteLine(samedayCost);
            Console.ReadLine();
        }
    }
}
