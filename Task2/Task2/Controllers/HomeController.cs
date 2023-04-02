using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            return View(nums);
        }
    }
}
