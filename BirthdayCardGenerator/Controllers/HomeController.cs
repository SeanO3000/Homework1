using BirthdayCardGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BirthdayCardGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult CardForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CardForm(Models.BirthdayMessage birthdayMessage)
        {
            if (ModelState.IsValid)
            {
                return View("CardSent", birthdayMessage);
            }
            else
            {
                return View();
            }
        }

    }
}