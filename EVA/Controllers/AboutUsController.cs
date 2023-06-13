using EVA.IServices;
using EVA.Models;
using EVA.Services;
using Microsoft.AspNetCore.Mvc;

namespace EVA.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public IActionResult AboutUs()
        {
            AboutUsViewModel about = _aboutUsService.GetAboutUsViewModel();
            return View("~/Views/Home/Aboutus.cshtml", about);
        }
    }
}
