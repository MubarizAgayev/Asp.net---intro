using Microsoft.AspNetCore.Mvc;

namespace AspNet_intro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
