using Hyperspace.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hyperspace.Controllers
{
    public class AboutController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Load()
        {
            var address = new Address()
            {
                IsActive = true,
                Info = "Data"
            };
            var data = new AboutLoadVM()
            {
                Name = "Matrix",
                Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur tellus augue.",
                AddressInfo = address
            };
            return View(data);
        }
    }
}
