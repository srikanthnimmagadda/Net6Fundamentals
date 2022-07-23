using Microsoft.AspNetCore.Mvc;
using Net6Fundamentals.Models;

namespace Net6Fundamentals.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pieRepository"></param>
        /// <param name="categoryRepository"></param>
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            PieListViewModel piesListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes");
            return View(piesListViewModel);
        }
    }
}
