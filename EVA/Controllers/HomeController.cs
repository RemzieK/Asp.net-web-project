using EVA.IServices;
using EVA.Models;
using EVA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;


namespace EVA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApodService _apodService;

        public HomeController(ILogger<HomeController> logger, ApodService apodService)
        {
            _logger = logger;
            _apodService = apodService;
        }

        public async Task<ActionResult> Apod(DateTime? date)
        {
            ApodDto? apod = await _apodService.GetApodData(date ?? DateTime.Today);
            return View(apod);
        }

        public IActionResult Index()
        {
            return RedirectToAction("Home", "Index");
        }

        public IActionResult Planets()
        {
            return RedirectToAction("Home", "Planets");
        }

        public IActionResult Galaxies()
        {
            return RedirectToAction("Home", "Galaxies");
        }

        public IActionResult Astronauts()
        {
            
           return RedirectToAction("Home", "Astronauts");
            
        }
            
        public IActionResult Aboutus()
        {
                return RedirectToAction("Home", "AboutUs");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}