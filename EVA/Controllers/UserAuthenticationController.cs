using Microsoft.AspNetCore.Mvc;
using EVA.Models.DTO;
using EVA.Repositories_regi.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace EVA.Controllers
{
    
    public class UserAuthenticationController : Controller
    {
       private readonly IUserAuthenticationService _service;
        public UserAuthenticationController(IUserAuthenticationService service)
        {
            this._service = service;
        }

        public IActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
           if(!ModelState.IsValid)
                return View(model);
            model.Role = "user";
           var result = await _service.RegistrationAsync(model);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result =await _service.LoginAsync(model);
            if (result.StatusCode == 1)
            {
                HttpContext.Session.SetString("IsAuthenticated", "true");
                 return RedirectToAction("DashDisplay", "Dashboard");
              
            }
            else
            {
                
                 TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Login));
            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _service.LogoutAsync();
            HttpContext.Session.Remove("IsAuthenticated");
            return RedirectToAction(nameof(Login));
        }

        //public async Task<IActionResult> reg()
        //{
        //    var model = new RegistrationModel
        //    {
        //        Username = "admin",
        //        Name = "Remington Leith",
        //        Email = "remington@gmail.com",
        //        Password = "Admin@12345#"
        //    };
        //    model.Role = "admin";
        //    var result = await _service.RegistrationAsync(model);
        //    return Ok(result);
        //}

    }
}
