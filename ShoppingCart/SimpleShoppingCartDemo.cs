namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {
        public static void Run()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            Product A = new Product("A", 40);
            Product B = new Product("B", 70);
            Product C = new Product("C", 30);

            shoppingCart.Show();
            shoppingCart.Buy(A, 1);
            shoppingCart.Show();
            shoppingCart.Buy(B, 3);
            shoppingCart.Show();
            shoppingCart.Buy(C, 4);
            shoppingCart.Show();

        }
    }
}