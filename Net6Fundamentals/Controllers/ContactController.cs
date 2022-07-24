using Microsoft.AspNetCore.Mvc;

namespace Net6Fundamentals.Controllers
{
    public class ContactController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
