using EVA.Models;
using Microsoft.AspNetCore.Mvc;

namespace EVA.Controllers
{
    public class ApodController : Controller
    {
       // [HttpGet]
        //public async Task<IActionResult> Apod(string date)
        //{
        //    if (string.IsNullOrEmpty(date))
        //    {
        //        date = DateTime.Today.ToString("yyyy-MM-dd");
        //    }

        //    var service = new NasaApodService();
        //    var apodInfo = await service.GetApodInfo(date);


        //    var model = new NasaApodViewModel
        //    {
        //        Date = date,
        //        Title = apodInfo.Title,
        //        Explanation = apodInfo.Explanation,
        //        Url = apodInfo.Url
        //    };

        //    return View("~/Views/Home/Apod.cshtml",model);

        //}
    }
}
