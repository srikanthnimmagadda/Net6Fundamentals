namespace Net6Fundamentals.Models
{
    public class ShoppingCartViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="shoppingCartTotal"></param>
        public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
        {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
        }

        public IShoppingCart ShoppingCart { get; }
        public decimal ShoppingCartTotal { get; }
    }
}
