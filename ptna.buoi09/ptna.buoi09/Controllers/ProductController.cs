using Microsoft.AspNetCore.Mvc;

namespace ptna.buoi09.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search() 
        { 
            return View(); 
        }
        public IActionResult Hots() 
        { 
            return View(); 
        }
        public IActionResult About() 
        { 
            return View(); 
        }
    }
}
