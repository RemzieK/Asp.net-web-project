using EVA.Models;
using Microsoft.AspNetCore.Mvc;
using NasaApodExample.Controllers;
using NasaApodExample.Models;
using System.Diagnostics;
using System.Reflection;

namespace EVA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
      
        }

        public async Task<ActionResult> Apod()
        {
            ApodController apodController = new ApodController();
            ApodModel? apod = await apodController.GetApodData();
            return View(apod);
        }

        public IActionResult Index()
        { 
           return View("~/Views/Home/Index.cshtml");
       }

        public IActionResult Planets()
        {
            return View();
        }

        public IActionResult Galaxies()
        {
            return View();
        }

        public IActionResult Austronauts()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}