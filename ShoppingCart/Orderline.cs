using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Orderline
    {
        public int Count { get; private set; }
        public Product Product { get; private set; }

        public Orderline(int count, Product product)
        {
            Count = count;
            Product = product;
        }

        public void AddCount(int amount)
        {
            Count += amount;
        }

        public int ShowOrderLine()
        {
            var price = Product.Price;
            var orderLinePrice = price * Count;
            Console.WriteLine($"  {Count} stk. {Product.Name} a kr {price} = {orderLinePrice}");
            return orderLinePrice;
        }

    }
}
