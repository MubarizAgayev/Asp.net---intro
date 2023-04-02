using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace Task3.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<string> names = new List<string>() { "Mubariz", "Shaiq", "konul", "Roya", "Aqshin" };
            return View(names);
;        }
    }
}
