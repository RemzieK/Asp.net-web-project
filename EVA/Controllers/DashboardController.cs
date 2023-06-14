using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EVA.Controllers
{
    
    public class DashboardController : Controller
    {
        [Authorize]
        public IActionResult DashDisplay()
        {
            return View();
        }
    }
}
