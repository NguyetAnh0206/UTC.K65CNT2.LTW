using Microsoft.AspNetCore.Mvc;

namespace ptna.lession04.Controllers
{
    public class RazorCobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
