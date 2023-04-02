using Microsoft.AspNetCore.Mvc;

namespace Task4.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            int number = 30;
            int a = 0;
            int b = 1;
            int result = 0;
            int count = 0;
            int[] fibnumbers = new int[number];
            for (int i = 0; i < fibnumbers.Length; i++)
            {
                if (a<=number)
                {
                    fibnumbers[i] = a;
                    result = a + b;
                    a = b;
                    b = result;
                    count++;
                }
            }
            return View(fibnumbers);
        }
    }
}
