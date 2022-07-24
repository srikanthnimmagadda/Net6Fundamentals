using Microsoft.AspNetCore.Mvc;
using Net6Fundamentals.Models;

namespace Net6Fundamentals.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly IShoppingCart _shoppingCart;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pieRepository"></param>
        /// <param name="shoppingCart"></param>
        public ShoppingCartController(IPieRepository pieRepository, IShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pieId"></param>
        /// <returns></returns>
        public RedirectToActionResult AddToShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);

            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pieId"></param>
        /// <returns></returns>
        public RedirectToActionResult RemoveFromShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}
