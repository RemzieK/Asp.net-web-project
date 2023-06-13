using EVA.IServices;
using EVA.Models;
using EVA.Services;
using Microsoft.AspNetCore.Mvc;

namespace EVA.Controllers
{
    public class GalaxiesController : Controller
    {
        private readonly IGalaxiesService _galaxiesService;


        public GalaxiesController(IGalaxiesService galaxiesService)
        {
            _galaxiesService = galaxiesService;
        }

        public IActionResult Galaxies()
        {
            GalaxiesViewModel galaxy = _galaxiesService.GetGalaxiesViewModel();
            return View("~/Views/Home/Galaxies.cshtml", galaxy);
        }
    }
}
