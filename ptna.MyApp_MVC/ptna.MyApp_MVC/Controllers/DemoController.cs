using Microsoft.AspNetCore.Mvc;

namespace ptna.MyApp_MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
