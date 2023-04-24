using EVA.Models;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index(string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                date = DateTime.Today.ToString("yyyy-MM-dd");
            }

            var service = new NasaApodService();
            var apodInfo = await service.GetApodInfo(date);
          
            //ViewBag.Date = date;
            var model = new NasaApodViewModel
            {
                Date = date,
                Title = apodInfo.Title,
                Explanation = apodInfo.Explanation,
                Url = apodInfo.Url
            };

            return View(model);

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
    }
}