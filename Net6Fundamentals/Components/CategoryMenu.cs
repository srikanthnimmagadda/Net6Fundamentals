using Net6Fundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace Net6Fundamentals.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryRepository"></param>
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
