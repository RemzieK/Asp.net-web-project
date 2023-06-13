using EVA.IServices;
using EVA.Models;
using Microsoft.AspNetCore.Mvc;

namespace EVA.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly IPlanetsService _planetsService;

        public PlanetsController(IPlanetsService planetsService)
        {
            _planetsService = planetsService;
        }

        public IActionResult Planets()
        {
            PlanetsViewModel planet = _planetsService.GetPlanetsViewModel();
            return View("~/Views/Home/Planets.cshtml", planet);
        }
    }
}
