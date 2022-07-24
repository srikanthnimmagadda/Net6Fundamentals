namespace Net6Fundamentals.Models
{
    public interface IShoppingCart
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pie"></param>
        void AddToCart(Pie pie);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pie"></param>
        /// <returns></returns>
        int RemoveFromCart(Pie pie);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<ShoppingCartItem> GetShoppingCartItems();

        /// <summary>
        /// 
        /// </summary>
        void ClearCart();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        decimal GetShoppingCartTotal();

        /// <summary>
        /// 
        /// </summary>
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
