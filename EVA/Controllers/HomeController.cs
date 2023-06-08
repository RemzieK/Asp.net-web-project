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
        private readonly IHomeService _homeService;
       

        public HomeController(ILogger<HomeController> logger, IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
           

        }

        public async Task<ActionResult> Apod()
        {
           
            ApodDto? apod = await _homeService.GetApodData();
            return View(apod);
        }

        public IActionResult Index()
        {
            var index = _homeService.GetIndexViewModel();
            return View(index);
           
       }

        public IActionResult Planets()
        {
            var planet = _homeService.GetPlanetsViewModel();
            return View(planet);
        }

        public IActionResult Galaxies()
        {
            var galaxy = _homeService.GetGalaxiesViewModel();
            return View(galaxy);
        }

        public IActionResult Astronauts()
        {
            
            var astro = _homeService.GetAstronautsViewModel();
            return View(astro);
        }

        public IActionResult Aboutus()
        {
           
            var model = _homeService.GetAboutUsViewModel();
            return View(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}