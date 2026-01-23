using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class SellerController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}