using Microsoft.AspNetCore.Mvc;

namespace WebApplication20240925.Controllers
{
    public class NumbersController : Controller
    {
        private readonly ILogger<NumbersController> _logger;

        public NumbersController(ILogger<NumbersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NumbersToN(int count = 3)
        {
            ViewBag.Count = count;
            return View();
        }
    }
}
