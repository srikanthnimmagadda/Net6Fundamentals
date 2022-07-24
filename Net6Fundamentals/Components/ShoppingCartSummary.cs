using Net6Fundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace Net6Fundamentals.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shoppingCart"></param>
        public ShoppingCartSummary(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            //var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            ShoppingCartViewModel? shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());
            return View(shoppingCartViewModel);
        }
    }
}
