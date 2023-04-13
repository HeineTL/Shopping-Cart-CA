using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class ShoppingCart
    {
        private List<Orderline> _orderlines;

        public ShoppingCart()
        {
            _orderlines = new List<Orderline>();
        }

        public void Buy(Product product, int amount)
        {
            Orderline orderline = new Orderline(amount, product);

            if (_orderlines.Contains(orderline))
            {
                var index = _orderlines.IndexOf(orderline);
                _orderlines[index].AddCount(amount);
            }
            else
            {
                _orderlines.Add(orderline);
            }

            Console.WriteLine($"Du kjøpte {amount} stk. {product.Name}");
        }

        public void Show()
        {
            if (_orderlines.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }

            Console.WriteLine("Handlekurv:");
            var totalPrice = 0;
            for (int i = 0; i < _orderlines.Count; i++)
            {
                int orderLinePrice = _orderlines[i].ShowOrderLine();
                totalPrice += orderLinePrice;
            }

            Console.WriteLine($"Totalpris: {totalPrice}");
            Console.WriteLine();
        }

    }
}
