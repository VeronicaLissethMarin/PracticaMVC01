using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC.Controllers
{
    public class equipos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
