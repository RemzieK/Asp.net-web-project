using EVA.IServices;
using EVA.Models;
using EVA.Services;
using Microsoft.AspNetCore.Mvc;

namespace EVA.Controllers
{
    public class IndexController : Controller
    {
        private readonly IIndexService _indexService;

        public IndexController(IIndexService indexService)
        {
            _indexService = indexService;
        }

        public IActionResult Index()
        {
            IndexViewModel index = _indexService.GetIndexViewModel();
            return View("~/Views/Home/Index.cshtml", index);
        }
    }
}
