using Microsoft.AspNetCore.Mvc;
using Net6Fundamentals.Models;
using System.Diagnostics;

namespace Net6Fundamentals.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pieRepository"></param>
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}