using EVA.IServices;
using EVA.Models;
using EVA.Services;
using Microsoft.AspNetCore.Mvc;

namespace EVA.Controllers
{
    public class AstronautsController : Controller
    {
        private readonly IAstronautsService _astronautsService;

        public AstronautsController(IAstronautsService astronautsService)
        {
            _astronautsService = astronautsService;
        }

        public IActionResult Astronauts()
        {
            AstronautsViewModel astro = _astronautsService.GetAstronautsViewModel();
            return View("~/Views/Home/Astronauts.cshtml", astro);
        }
    }
}
