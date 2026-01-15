using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {    ViewData["Message"] = "Salles Web MVC App";
             ViewData["Developer"] = "Ricardo Pereira";

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Metallica.";
            ViewData["email"] = "ricardodatadev@gmail.com";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new MyProject.Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
