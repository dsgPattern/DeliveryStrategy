using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryStrategy
{
    class Order
    {
        public List<Product> Products { get; set; }
        public double DistanceToDestination { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
