using Microsoft.AspNetCore.Mvc;

namespace MySite2.WebApp.Controllers
{
    public class RunsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
