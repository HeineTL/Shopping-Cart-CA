namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {
        public static void Run()
        {
            //var productNames = new[] { "A", "B", "C" };
            //var prices = new[] { 40, 70, 30 };

            Product A = new Product("A", 40);
            Product B = new Product("B", 70);
            Product C = new Product("C", 30);

            Product[] products = { A, B, C };

            List<Orderline> myShoppingCart = new List<Orderline>();

            ShowCart(products, myShoppingCart);
            Buy(A, 1, myShoppingCart);
            ShowCart(products, myShoppingCart);
            Buy(B, 3, myShoppingCart);
            ShowCart(products, myShoppingCart);
            Buy(C, 4, myShoppingCart);
            ShowCart(products, myShoppingCart);
        }

        private static void Buy(Product product, int amount, List<Orderline> shoppingCart)
        {
            Orderline orderline = new Orderline(amount, product);

            if (shoppingCart.Contains(orderline))
            {
                var shoppingCartIndex = shoppingCart.IndexOf(orderline);
                shoppingCart[shoppingCartIndex].AddCount(amount);
            }

            else
            {
                shoppingCart.Add(orderline);
            }

            Console.WriteLine($"Du kjøpte {amount} stk. {product.Name}");
        }

        private static void ShowCart(Product[] products, List<Orderline> orderline)
        {
            if (orderline.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }

            Console.WriteLine("Handlekurv:");
            var totalPrice = 0;
            for (int i = 0; i < orderline.Count; i++)
            {
                var count = orderline[i].GetCount();
                var product = orderline[i].GetProduct();
                var price = product.Price;
                var orderLinePrice = price * count;
                Console.WriteLine($"  {count} stk. {product.Name} a kr {products[i].Price} = {orderLinePrice}");
                totalPrice += orderLinePrice;
            }

            Console.WriteLine($"Totalpris: {totalPrice}");
        }
    }
}
