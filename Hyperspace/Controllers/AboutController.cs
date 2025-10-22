using Microsoft.AspNetCore.Mvc;

namespace Hyperspace.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
