using System.Diagnostics;
using Hyperspace.Dto;
using Hyperspace.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hyperspace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(new ForPartial()
            {
                 Name = "Matrix Academy 2025",
                 Age = 10
            });
        }

        public IActionResult Privacy()
        {
            return View(new ForPartial()
            {
                Name = "Matrix Academy 2025",
                Age = 15
            });
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactPostDto model)
        {
            if (ModelState.IsValid)
            {
                //save to db
                return RedirectToAction(actionName: "Index", controllerName: "Home");
            }
            else
            {
                return View(model);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
