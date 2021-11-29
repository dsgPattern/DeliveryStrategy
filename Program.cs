using System;

namespace DeliveryStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.AddProduct(new Product{Name = "Smartphone", Weight = 0.3, Price = 2400});
            order.AddProduct(new Product { Name = "Dishwasher", Weight = 10, Price = 1500});
            order.DistanceToDestination = 210;

            var fanCurierCost = new FanCurierCostCalculator().GetShippingCost(order);
            var samedayCost = new SamedayCostCalculator().GetShippingCost(order);
            Console.WriteLine(fanCurierCost);
            Console.WriteLine(samedayCost);
            Console.WriteLine();

            var storeCheckout = new StoreCheckout(order);
            storeCheckout.SetShippingMethod(new FanCurierCostCalculator());
            Console.WriteLine(storeCheckout.GetTotalCost());

            storeCheckout.SetShippingMethod(new SamedayCostCalculator());
            Console.WriteLine(storeCheckout.GetTotalCost());

            Console.ReadLine();
        }
    }
}
