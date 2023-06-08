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
        //private readonly ApodService _apodService;
        //private readonly IAboutUsService _aboutUsService;
        //private readonly IAstronautsService _astronautsService;

        public HomeController(ILogger<HomeController> logger, IHomeService homeService/*ApodService apodService, IAboutUsService aboutUsService, IAstronautsService astronautsService*/)
        {
            _logger = logger;
            _homeService = homeService;
            // _apodService = apodService;
            //_aboutUsService = aboutUsService;
            //_astronautsService = astronautsService;

        }

        public async Task<ActionResult> Apod()
        {
            //ApodDto? apod = await _apodService.GetApodData();
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
            //  var astro = _astronautsService.GetAstronautsViewModel();
            var astro = _homeService.GetAstronautsViewModel();
            return View(astro);
        }

        public IActionResult Aboutus()
        {
            // var model = _aboutUsService.GetAboutUsViewModel();
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