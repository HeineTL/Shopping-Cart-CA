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
        private int Count;
        private Product Product;

        public Orderline(int count, Product product)
        {
            Count = count;
            Product = product;
        }

        public void AddCount(int amount)
        {
            Count += amount;
        }

        public int ShowLine(Orderline orderline)
        {
            var count = orderline.GetCount();
            var product = orderline.GetProduct();
            var price = product.Price;
            var orderLinePrice = price * count;
            Console.WriteLine($"  {count} stk. {product.Name} a kr {price} = {orderLinePrice}");
            return orderLinePrice;
        }

        public int GetCount() { return Count; }
        public Product GetProduct() { return Product; }


    }
}
