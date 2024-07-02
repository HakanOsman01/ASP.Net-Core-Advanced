using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.CoreDemo_Advanced.Controllers
{
    public class NumberController : Controller
    {
        [HttpGet]
        public IActionResult Index(int count) => View(count);


        [HttpPost]
        public IActionResult PrintNumbers(int count)
        {
            
            return RedirectToAction(nameof(Index),count);
        }
    }
}
