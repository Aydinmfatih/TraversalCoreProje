using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> SignUp( )
        {
           return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel item)
        {
            AppUser appUser = new AppUser()
            {
                Name = item.Name,
                Surname = item.Surname,
                Email = item.Mail,
                UserName = item.Username,

            };
            if (item.Password == item.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, item.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var model in result.Errors)
                    {
                        ModelState.AddModelError("", model.Description);
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
